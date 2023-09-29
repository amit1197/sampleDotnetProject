using Microsoft.AspNetCore.Mvc;
using sampleDotnetProject.Services.StudentService;
//using Microsoft.AspNetCore.Http;


namespace sampleDotnetProject.Controllers;

[ApiController]
[Route("api/[controller]")]

public class StudentController : ControllerBase
{

    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAllStudents()
    {
        return _studentService.GetAllStudents();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetSingleStudent(int id)
    {
        // var result = await _superHeroService.GetSingleHero(id);
        var student = _studentService.GetSingleStudent(id);
        if(student is null) 
        {
            return NotFound("student not found");
        }
        return Ok(student);
    }

    [HttpPost]
    public async Task<ActionResult<List<Student>>> AddStudent(Student student)
    {
        var res = _studentService.AddStudent(student);
        return Ok(res);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<List<Student>>> UpdateStudent(int id, Student request)
    {
        var student = _studentService.UpdateStudent(id, request);
        if(student is null)
        {
            return NotFound("Student not found");
        }
        return Ok(student);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Student>>> DeleteStudent(int id)
    {
        var student = _studentService.DeleteStudent(id);
        if(student is null)
        {
            return NotFound("Student not found");
        }
        return Ok(student);
    }

    
}