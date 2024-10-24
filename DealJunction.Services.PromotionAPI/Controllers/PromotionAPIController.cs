using AutoMapper;
using DealJunction.Services.PromotionAPI.Models;
using DealJunction.Services.PromotionAPI.Models.PromotionDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealJunction.Services.PromotionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionAPIController : ControllerBase
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public PromotionAPIController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Promotion>>> GetAll()
        {
            return await _context.Promotions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadPromotionDto>> Get(int id)
        {
            var promotion = await _context.Promotions.FirstOrDefaultAsync(p => p.Id == id);

            if (promotion == null)
            {
                return NotFound();
            }
            var responsedPromotion = _mapper.Map<ReadPromotionDto>(promotion);

            return responsedPromotion;
        }

        [HttpPost]
        public async Task<ActionResult<Promotion>> CreatePromotion([FromBody] CreatePromotionDto promotion)
        {
            if (promotion == null)
            {
                return BadRequest("Invalid promotion data.");
            }
            var promotionEntity = _mapper.Map<Promotion>(promotion);

            var employee = await _context.Employees.FindAsync(promotionEntity.EmployeeId);
            if (employee == null)
            {
                return NotFound($"Employee with Id {promotionEntity.EmployeeId} not found.");
            }

            promotionEntity.CreatedAt = DateTimeOffset.Now;
            promotionEntity.UpdatedAt = DateTimeOffset.Now;
            _context.Promotions.Add(promotionEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = promotionEntity.Id }, promotion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePromotion(int id, [FromBody] UpdatePromotionDto promotionDto)
        {

            var existingPromotion = await _context.Promotions.FindAsync(id);
            if (existingPromotion == null)
            {
                return NotFound($"Promotion with Id {id} not found.");
            }

            _mapper.Map(promotionDto, existingPromotion);
            existingPromotion.UpdatedAt = DateTimeOffset.Now;

            _context.Entry(existingPromotion).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(existingPromotion);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromotion(int id)
        {
            var promotion = await _context.Promotions.FindAsync(id);
            if (promotion == null)
            {
                return NotFound($"Promotion with Id {id} not found.");
            }

            _context.Promotions.Remove(promotion);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
