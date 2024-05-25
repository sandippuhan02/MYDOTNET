namespace TagHelperDemo.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public Country Country {  get; set; }   
        public Gender Gender { get; set; }
        public int Salary {  get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    } 
    public enum Country
    {
        India,
        England,
        Austrelia,
        SouhAfrica
    }
}
