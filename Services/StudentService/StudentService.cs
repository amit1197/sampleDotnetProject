namespace sampleDotnetProject.Services.StudentService
{
    public class StudentService: IStudentService
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
 


        public List<Student> AddStudent(Student student){
            students.Add(student);
            return students;
        }

        public List<Student>? DeleteStudent(int id){
            var student = students.Find(x => x.Student_ID == id);
            if(student is null) {
                return null;
            }
            students.Remove(student);
            return students;
        }

        public List<Student> GetAllStudents(){
            return students;
        }

        public Student? GetSingleStudent(int id){
            var student = students.Find(x => x.Student_ID == id);
            if(student is null) {
                return null;
            }
            return student;
        }

        public List<Student>? UpdateStudent(int id, Student request){
            var student = students.Find(x => x.Student_ID == id);
            if(student is null) return null;
            student.Gender = request.Gender;
            student.Marks = request.Marks;
            return students;
        }
    }
}