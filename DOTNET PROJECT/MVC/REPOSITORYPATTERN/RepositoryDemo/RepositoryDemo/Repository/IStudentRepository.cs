using RepositoryDemo.Models;

namespace RepositoryDemo.Repository
{
    public interface IStudentRepository
    {
        List<Student> Students();
        Student GetStudent(int id);
    }
}
