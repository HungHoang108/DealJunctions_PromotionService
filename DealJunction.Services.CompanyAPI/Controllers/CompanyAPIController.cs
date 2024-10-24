using AutoMapper;
using DealJunction.Services.CompanyAPI.Models;
using DealJunction.Services.CompanyAPI.Models.CompanyDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealJunction.Services.CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAPIController : ControllerBase
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public CompanyAPIController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetAll()
        {
            return await _context.Companies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadCompanyDto>> Get(int id)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(p => p.Id == id);

            if (company == null)
            {
                return NotFound();
            }
            var responsedCompany = _mapper.Map<ReadCompanyDto>(company);

            return responsedCompany;
        }

        [HttpPost]
        public async Task<ActionResult<Company>> CreateCompany([FromBody] CreateCompanyDto company)
        {
            if (company == null)
            {
                return BadRequest("Invalid Company data.");
            }
            var companyEntity = _mapper.Map<Company>(company);

            companyEntity.CreatedAt = DateTimeOffset.Now;
            companyEntity.UpdatedAt = DateTimeOffset.Now;
            _context.Companies.Add(companyEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = companyEntity.Id }, company);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] UpdateCompanyDto companyDto)
        {

            var existingCompany = await _context.Companies.FindAsync(id);
            if (existingCompany == null)
            {
                return NotFound($"Company with Id {id} not found.");
            }

            _mapper.Map(companyDto, existingCompany);
            existingCompany.UpdatedAt = DateTimeOffset.Now;

            _context.Entry(existingCompany).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(existingCompany);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound($"Company with Id {id} not found.");
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
