using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC_PremiumInterface.Data;
using POC_PremiumInterface.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_PremiumInterface.Controllers
{
    [ApiController]
    [Route("api/zpmtran")]
    public class ZPMTransactionController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ZPMTransactionController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ZPMTransactionResponseDto>>> Get([FromQuery] int transactionStatusId)
        {
            var zpm = await _context.ZPMTransaction.Where(x => x.TransactionStatusId == transactionStatusId).ToListAsync();
            if (zpm == null) return Ok($"id {transactionStatusId} not found");
            var model = new ZPMTransactionResponseDto();

            return Ok(zpm);
        }
    }
}