using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;
using sampleDotnetProject.Models;

namespace sampleDotnetProject.Controllers;

[ApiController]
[Route("api/[controller]")]

public class StudentController : ControllerBase
{

    private static List<Student> students = new List<Student> {
        new Student
        {
            Student_ID = 1,
            Gender = "M",
            Marks = 50

        },
        new Student
        {
            Student_ID = 2,
            Gender = "F",
            Marks = 70

        }
    };

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAllStudents()
    {
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<List<Student>>> GetSingleStudent(int id)
    {
        // var result = await _superHeroService.GetSingleHero(id);
        var student = students.Find(x => x.Student_ID == id);
        return Ok(student);
    }


    
}