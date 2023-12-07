using BlazorWasm.Models;

namespace BlazorWasm.Services
{
    public class StudentRepo : IStudentRepo
    {
 
        private List<Student> _students = new List<Student>();  
        
        void IStudentRepo.Add()
        {
            _students.Add(new Student { Name = Guid.NewGuid().ToString() });
        }

        List<Student> IStudentRepo.Get()
        {
            return _students;
        }
    }
}
