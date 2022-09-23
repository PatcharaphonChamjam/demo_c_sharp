using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC_PremiumInterface.Data;
using POC_PremiumInterface.DTOs;
using POC_PremiumInterface.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_PremiumInterface.Controllers
{
    [ApiController]
    [Route("api/bank")]
    public class MappingBankController : ControllerBase
    {
        private readonly AppDBContext _context;

        public MappingBankController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MappingBank>>> Get()
        {
            var bank = await _context.MappingBank.AsNoTracking().ToListAsync();
            return Ok(bank);
        }

        [HttpGet("{BankId}")]
        public async Task<ActionResult<MappingBank>> Get(int BankId)
        {
            var bank = _context.MappingBank.Where(x => x.BankId == BankId).FirstOrDefault();
            if (bank == null) return Ok($"id {BankId} not found.");
            return Ok(bank);
        }
    }
}