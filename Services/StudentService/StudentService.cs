namespace sampleDotnetProject.Services.StudentService
{
    public class StudentService: IStudentService
    {

 
        private readonly DataContext _context;

        public StudentService(DataContext context)
        {
            _context = context;
        }


        public async Task<List<Student>> AddStudent(Student student){
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return await _context.Students.ToListAsync();
        }

        public async Task<List<Student>?> DeleteStudent(int id){
            var student = await _context.Students.FindAsync(id);
            if(student is null) {
                return null;
            }
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return await _context.Students.ToListAsync();
        }

        public async Task<List<Student>> GetAllStudents(){
            var students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<Student?> GetSingleStudent(int id){
            var student = await _context.Students.FindAsync(id);
            if(student is null) {
                return null;
            }
            return student;
        }

        public async Task<List<Student>?> UpdateStudent(int id, Student request){
            var student = await _context.Students.FindAsync(id);
            if(student is null) return null;
            student.Gender = request.Gender;
            student.Marks = request.Marks;

            await _context.SaveChangesAsync();

            return await _context.Students.ToListAsync();
        }
    }
}