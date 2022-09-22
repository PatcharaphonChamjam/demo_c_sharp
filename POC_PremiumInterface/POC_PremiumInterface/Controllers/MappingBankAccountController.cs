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
    [Route("api/bankaccount")]
    public class MappingBankAccountController : ControllerBase
    {
        private readonly AppDBContext _context;

        public MappingBankAccountController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MappingBankAccount>>> Get()
        {
            var bankac = await _context.MappingBankAccount.AsNoTracking().ToListAsync();
            return Ok(bankac);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MappingBankAccount>> Get(int id)
        {
            var bankac = await _context.MappingBankAccount.Where(x => x.BankId == id).FirstOrDefaultAsync();
            if (bankac == null) return Ok($"id {id} not found.");

            return Ok(bankac);
        }
    }
}