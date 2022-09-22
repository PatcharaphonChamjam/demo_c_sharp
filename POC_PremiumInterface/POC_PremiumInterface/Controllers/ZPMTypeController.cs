using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC_PremiumInterface.Data;
using POC_PremiumInterface.DTOs;
using POC_PremiumInterface.Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace POC_PremiumInterface.Controllers
{
    [ApiController]
    [Route("api/zpmtype")]
    public class ZPMTypeController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ZPMTypeController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ZPMTypeResponseDto>>> Get()
        {
            var zpm = await _context.ZPMType.AsNoTracking().ToListAsync();
            var zpmDTOs = new List<ZPMTypeResponseDto>();
            foreach (var _zpm in zpm)
            {
                zpmDTOs.Add(new ZPMTypeResponseDto()
                {
                    ZPMTypeId = _zpm.ZPMTypeId,
                    ZPMTypeCode = _zpm.ZPMTypeCode,
                    ZPMTypeDetail = _zpm.ZPMTypeDetail,
                    IsActive = _zpm.IsActive
                });
            }
            return Ok(zpmDTOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ZPMTypeResponseDto>> Get(int id)
        {
            var zpm = await _context.ZPMType.Where(x => x.ZPMTypeId == id).FirstOrDefaultAsync();

            if (zpm == null) return Ok($"id {id} not found.");
            //var zpmDTOs = new List<ZPMTypeResponseDto>();

            var zpmDTO = new ZPMTypeResponseDto();

            zpmDTO.ZPMTypeId = zpm.ZPMTypeId;
            zpmDTO.ZPMTypeCode = zpm.ZPMTypeCode;
            zpmDTO.ZPMTypeDetail = zpm.ZPMTypeDetail;
            zpmDTO.IsActive = zpm.IsActive;

            return Ok(zpmDTO);
        }
    }
}