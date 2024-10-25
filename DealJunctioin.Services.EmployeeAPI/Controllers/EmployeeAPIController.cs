using AutoMapper;
using DealJunction.Services.EmployeeAPI.Models;
using DealJunction.Services.EmployeeAPI.Models.EmployeeDto;
using DealJunction.Services.EmployeeAPI.RabbitMQSender;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealJunction.Services.EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;
        private readonly IRabbitMQMessageSender _rabbitMQSender;

        public EmployeeAPIController(AppDbContext context, IMapper mapper, IRabbitMQMessageSender rabbitMQMessageSender)
        {
            _context = context;
            _mapper = mapper;
            _rabbitMQSender = rabbitMQMessageSender;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadEmployeeDto>> Get(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(p => p.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return _mapper.Map<ReadEmployeeDto>(employee); ;
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee([FromBody] CreateEmployeeDto employeeDto)
        {
            if (employeeDto == null)
            {
                return BadRequest("Invalid employee data.");
            }
            var employeeEntity = _mapper.Map<Employee>(employeeDto);

            employeeEntity.CreatedAt = DateTimeOffset.Now;
            employeeEntity.UpdatedAt = DateTimeOffset.Now;
            _context.Employees.Add(employeeEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = employeeEntity.Id }, employeeDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] UpdateEmployeeDto employeeDto)
        {

            var existingEmployee = await _context.Employees.FindAsync(id);
            if (existingEmployee == null)
            {
                return NotFound($"Employee with Id {id} not found.");
            }

            _mapper.Map(employeeDto, existingEmployee);
            existingEmployee.UpdatedAt = DateTimeOffset.Now;

            _context.Entry(existingEmployee).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(existingEmployee);
        }

        [HttpPost("/Login")]
        public async Task<IActionResult> Login([FromBody] EmployeeLoginRequest request)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(p => p.Email == request.Email);

            if (employee == null)
            {
                return NotFound();

            }

            _rabbitMQSender.SendMessage(employee.Email.ToString(), "current-employee1");
            return Ok("Login successful!");
        }
    }
}
