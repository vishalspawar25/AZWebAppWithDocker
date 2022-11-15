using Microsoft.AspNetCore.Mvc;
namespace Agilisys.Employee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public async Task<ICollection<Models.Employee>> GetEmployeesAsync()
    {

        return new List<Models.Employee>();
    }

    [HttpPost]
    public async Task<IActionResult> PostEmployeesAsync(Models.Employee employee)
    {
        return Ok();
    }

}