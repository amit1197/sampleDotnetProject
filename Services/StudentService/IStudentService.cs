namespace sampleDotnetProject.Services.StudentService
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();

        Task<Student?> GetSingleStudent(int id);

        Task<List<Student>> AddStudent(Student student);

        Task<List<Student>?> UpdateStudent(int id, Student request);

        Task<List<Student>?> DeleteStudent(int id);




    }
}