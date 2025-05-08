namespace Basics_of_Types
{
    internal class Employee
    {
        public string Name;
        public int YearsEmployed;

        public int GetExperience()
        {
            return YearsEmployed;
        }
        public virtual string GetProgressReport()
        {
            return "Employee report";
        }
        public static Employee Lookup(string name)
        {
            return new Seller(name);
        }
    }
}
