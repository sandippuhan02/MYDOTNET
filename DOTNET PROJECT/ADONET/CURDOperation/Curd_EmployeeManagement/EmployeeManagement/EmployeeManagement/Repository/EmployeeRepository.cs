namespace EmployeeManagement.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public void Test()
        {
            Console.WriteLine("Trace @{0} Test Sucessful",DateTime.Now);
        }
    }
}
