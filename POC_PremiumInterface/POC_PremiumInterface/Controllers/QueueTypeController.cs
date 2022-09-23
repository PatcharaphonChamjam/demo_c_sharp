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
    [Route("api/queuetype")]
    public class QueueTypeController : ControllerBase
    {
        private readonly AppDBContext _context;

        public QueueTypeController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<QueueTypeResponseDto>>> Get()
        {
            var queue = await _context.QueueType.AsNoTracking().ToListAsync();
            var queueDTO = new List<QueueTypeResponseDto>();

            foreach (var _queue in queue)
            {
                queueDTO.Add(new QueueTypeResponseDto()
                {
                    QueueTypeId = _queue.QueueTypeId,
                    QueueTypeDetail = _queue.QueueTypeDetail,
                    IsActive = _queue.IsActive,
                });
            }
            return Ok(queueDTO);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<QueueTypeResponseDto>> Get(int id)
        {
            var queue = await _context.QueueType.Where(x => x.QueueTypeId == id).FirstOrDefaultAsync();
            if (queue == null) return Ok($"id {id} not found.");
            var queueDTO = new QueueType();
            queueDTO.QueueTypeId = queue.QueueTypeId;
            queueDTO.QueueTypeDetail = queue.QueueTypeDetail;
            queueDTO.IsActive = queue.IsActive;

            return Ok(queueDTO);
        }
    }
}