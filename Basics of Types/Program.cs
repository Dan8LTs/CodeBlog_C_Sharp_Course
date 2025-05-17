namespace Basics_of_Types
{
    internal class Program()
    {
        public static void Main(string[] args)
        {
            object o = new Employee();
            Employee e = (Employee)o;
            Console.WriteLine(e.GetType());

            Seller Max = new Seller("Maxim");
            PromoteEmployee(Max);

            Pizza pepperoni = new Pizza();
            // PromoteEmployee(pepperoni); => Invalid cast exception

            static void PromoteEmployee(object o)
            {
                Employee e = (Employee)o;
                Console.WriteLine(e.Name);
            }

            Console.WriteLine(o is Object);
            Console.WriteLine(o is Employee);

            object obj = new Object();
            Console.WriteLine(obj is Object);
            Console.WriteLine(obj is Employee);

            /*
            if (obj is Employee)
            {
                Employee emp = (Employee)obj;
            }
            else
            {
                //NULL CASE
            }
            */
            Employee emp = obj as Employee;
            if (emp != null)
            {
                //NULL CASE
            }

            LTs.Employee e2 = new LTs.Employee();
            Console.WriteLine(e2.GetType());

            Employee e3;
            e3 = new Seller();
            e3 = Employee.Lookup("Bob");
            e3.YearsEmployed = 3;

            Console.WriteLine(e3.GetProgressReport());
            Console.WriteLine(e3.GetExperience());
        }
    }
}