using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC_PremiumInterface.Data;
using POC_PremiumInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_PremiumInterface.Controllers
{
    [ApiController]
    [Route("api/queue")]
    public class QueueController : ControllerBase
    {
        private readonly AppDBContext _context;

        public QueueController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Queue>>> Get()
        {
            var queue = await _context.Queue.AsNoTracking().ToListAsync();
            return Ok(queue);
        }

        [HttpGet("{QueuestatusId}")]
        public async Task<ActionResult<Queue>> Get(int QueuestatusId)
        {
            var queue = await _context.Queue.Where(x => x.QueuestatusId == QueuestatusId).ToListAsync();
            if (queue == null) return Ok($"id {QueuestatusId} not found.");
            return Ok(queue);
        }
    }
}