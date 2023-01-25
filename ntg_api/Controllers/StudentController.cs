using Microsoft.AspNetCore.Mvc;
using ntg_api.Models;
using ntg_api.Services;
using System.Threading.Tasks;

namespace ntg_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
       public StudentController(IStudentService studentService) {
            this._studentService = studentService;
        }

        [HttpGet("GetStudent")]
        public async Task<IActionResult> GetStudent()
        {
            return Ok(await _studentService.GetStuddent());
        }

        [HttpPost ("AddStudent")]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            return Ok(await _studentService.AddStudent(student));
        }

        [HttpPut("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent([FromBody] Student student)
        {
            return Ok(await _studentService.UpdateStudent(student));
        }

    }
}
