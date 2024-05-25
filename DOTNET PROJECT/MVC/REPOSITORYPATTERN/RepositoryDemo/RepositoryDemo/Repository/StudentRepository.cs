using RepositoryDemo.Models;

namespace RepositoryDemo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> Students()
        {
            return DataSource();
        }
        public Student GetStudent(int id)
        {
            return DataSource().FirstOrDefault(x => x.RollNo == id);
        }
        private List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() {Name="Ashu",RollNo=10,City="BLS"},
                new Student() {Name="Suraj",RollNo=11,City="BLS"},
                new Student() {Name="Sandip",RollNo=12,City="BLS"},
                new Student() {Name="Sandip",RollNo=16,City="BLS"}
            };
        }
    }
}
