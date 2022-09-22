using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC_PremiumInterface.Data;
using POC_PremiumInterface.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_PremiumInterface.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class MappingProductTypeController : ControllerBase
    {
        private readonly AppDBContext _context;

        public MappingProductTypeController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MappingProductType>>> Get()
        {
            var product = await _context.MappingProductType.AsNoTracking().ToListAsync();
            return Ok(product);
        }

        [HttpGet("{ProductTypeId}")]
        public async Task<ActionResult<MappingProductType>> Get(int ProductTypeId)
        {
            var product = await _context.MappingProductType.Where(x => x.ProductTypeId == ProductTypeId).FirstOrDefaultAsync();
            if (product == null) return Ok($"id {ProductTypeId} not found.");
            return Ok(product);
        }
    }
}