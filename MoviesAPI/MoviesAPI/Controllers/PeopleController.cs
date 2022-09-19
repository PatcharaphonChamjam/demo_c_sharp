using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.DTOs;
using MoviesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MoviesAPI.Services;
using System.IO;
using Microsoft.AspNetCore.JsonPatch;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        private readonly Data.ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IFileStorageService fileStorageService;
        private readonly string containerName = "people";

        public PeopleController(Data.ApplicationDbContext context
            , IMapper mapper
            , IFileStorageService fileStorageService)
        {
            this.context = context;
            this.mapper = mapper;
            this.fileStorageService = fileStorageService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonFullDetailDTO>>> Get()
        {
            var people = await context.Person.Include(p => p.Gender).Include(d => d.Department)
                .Select(r => new
                {
                    Fullname = $"{r.FirstName} {r.LastName}",
                    Gender = r.Gender.GenderDetail,
                    Department = r.Department.DepartmentDetail
                }).ToListAsync();

            return Ok(people);
        }

        [HttpGet("{id}", Name = "getPerson")]
        public async Task<ActionResult<PersonFullDetailDTO>> Get(int id)
        {
            //Lemda Expression Join
            /*var query = await (context.Person.Where(p => p.Id == id)
                        .Join(context.Gender,
                            person => person.GenderId,
                            gender => gender.GenderId,
                            (person, gender) =>
                            new { person, gender })
                        .Join(context.Department,
                        person => person.person.DepartmentId,
                        department => department.DepartmentId,
                        (p, department) => new { p, department })
                        .Select(r => new
                        {
                            FullName = $"{r.p.person.FirstName} {r.p.person.LastName}",
                            Gender = r.p.gender.GenderDetail,
                            Department = r.department.DepartmentDetail
                        })).FirstOrDefaultAsync();*/

            //Include ต้องใส่ Relationship ใน  Database แล้ว Reverse Enginere ให้ Model Update
            var database = await context.Person.Where(p => p.Id == id).Include(p => p.Gender).Include(d => d.Department)
                .Select(r => new
                {
                    FullName = $"{r.FirstName} {r.LastName}",
                    Gender = r.Gender.GenderDetail,
                    Department = r.Department.DepartmentDetail
                }).FirstOrDefaultAsync();

            //Simple Join
            /*var peopleJoin = await (from p in context.Person
                                    where p.Id == id
                                    join g in context.Gender
                                    on p.GenderId equals g.GenderId
                                    join d in context.Department
                                    on p.DepartmentId equals d.DepartmentId

                                    select new { Fullname = $"{p.FirstName} {p.LastName}", Gender = g.GenderDetail, Department = d.DepartmentDetail }).FirstOrDefaultAsync();*/

            var output = new PersonFullDetailDTO() { Fullname = database.FullName, Gender = database.Gender, Department = database.Department };
            return output;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] PersonCreationDTO personCreationDTO)
        {
            var people = mapper.Map<Person>(personCreationDTO);

            if (personCreationDTO.Picture != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await personCreationDTO.Picture.CopyToAsync(memoryStream);
                    var content = memoryStream.ToArray();
                    var extention = Path.GetExtension(personCreationDTO.Picture.FileName);
                    people.Picture =
                        await fileStorageService.SaveFile(content, extention,
                        containerName, personCreationDTO.Picture.ContentType);
                }
            }
            context.Add(people);
            await context.SaveChangesAsync();
            var peopleDTO = mapper.Map<PersonDTO>(people);
            return new CreatedAtRouteResult("getPerson", new { id = people.Id }, peopleDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PersonCreationDTO personCreationDTO)
        {
            var people = mapper.Map<Person>(personCreationDTO);
            people.Id = id;
            context.Entry(people).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Person.AnyAsync(x => x.Id == id);
            if (!exists)
            {
                return NotFound();
            }
            context.Remove(new Person() { Id = id });
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> Patch(int id, [FromBody] JsonPatchDocument<PersonPatchDTO> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest();
            }
            var entityFromDB = await context.Person.FirstOrDefaultAsync(x => x.Id == id);
            if (entityFromDB == null)
            {
                return NotFound();
            }

            var entityDTO = mapper.Map<PersonPatchDTO>(entityFromDB);
            patchDocument.ApplyTo(entityDTO, ModelState);

            var isValid = TryValidateModel(entityDTO);
            if (!isValid)
            {
                return BadRequest(ModelState);
            }
            mapper.Map(entityDTO, entityFromDB);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}