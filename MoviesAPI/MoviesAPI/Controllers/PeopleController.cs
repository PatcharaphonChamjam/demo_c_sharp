using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.DTOs;
using MoviesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        private readonly Data.ApplicationDbContext context;
        private readonly IMapper mapper;

        public PeopleController(Data.ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonDTO>>> Get()
        {
            var people = await context.Person.ToListAsync();

            return mapper.Map<List<PersonDTO>>(people);
        }

        [HttpGet("{id}", Name = "getPerson")]
        public async Task<ActionResult<PersonFullDetailDTO>> Get(int id)
        {
            //Lemda Expression Join
            var query = await (context.Person.Where(p => p.Id == id)
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
                        })).FirstOrDefaultAsync();

            //Include ต้องใส่ Relationship ใน  Database แล้ว Reverse Enginere ให้ Model Update
            var database = await context.Person.Where(p => p.Id == id).Include(p => p.Gender).Include(d => d.Department)
                .Select(r => new
                {
                    FullName = $"{r.FirstName} {r.LastName}",
                    Gender = r.Gender.GenderDetail,
                    Department = r.Department.DepartmentDetail
                }).FirstOrDefaultAsync();

            //Simple Join
            var peopleJoin = await (from p in context.Person
                                    where p.Id == id
                                    join g in context.Gender
                                    on p.GenderId equals g.GenderId
                                    join d in context.Department
                                    on p.DepartmentId equals d.DepartmentId

                                    select new { Fullname = $"{p.FirstName} {p.LastName}", Gender = g.GenderDetail, Department = d.DepartmentDetail }).FirstOrDefaultAsync();

            //var output = new PersonFullDetailDTO() { Fullname = peopleJoin.Fullname, Gender = peopleJoin.Gender, Department = peopleJoin.Department };
            var output2 = new PersonFullDetailDTO() { Fullname = database.FullName, Gender = database.Gender, Department = database.Department };
            return output2;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonCreationDTO personCreationDTO)
        {
            var people = mapper.Map<Person>(personCreationDTO);
            context.Add(people);
            await context.SaveChangesAsync();
            var peopleDTO = mapper.Map<PersonDTO>(people);
            return new CreatedAtRouteResult("getPerson", new { id = people.Id }, peopleDTO);
        }
    }
}