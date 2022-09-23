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

        //TODO ส่ง BankAccountNo หรือ BankId คะ
        [HttpGet("{BankAccountNo}")]
        public async Task<ActionResult<MappingBankAccount>> Get(string BankAccountNo)
        {
            var bankac = await _context.MappingBankAccount.Where(x => x.BankAccountNo == BankAccountNo).FirstOrDefaultAsync();
            if (bankac == null) return Ok($"id {BankAccountNo} not found.");

            return Ok(bankac);
        }
    }
}