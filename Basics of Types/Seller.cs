namespace Basics_of_Types
{
    internal class Seller : Employee
    {
        public static int salesCount;

        public Seller() { }
        public Seller(string name)
        {
            Name = name;
        }
        public override string GetProgressReport()
        {
            return "Seller report";
        }
    }
}
