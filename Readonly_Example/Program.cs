namespace Readonly_Example
{
    class Readonly_Example
    {
        static readonly Class MyClass;

        static Readonly_Example()
        {
            MyClass = new Class("constructor");
        }

        static void Main(string[] args)
        {
            MyClass.Write();
            MyClass.Text = "We can change text";
            //We can't write MyClass = new Class("");
            Print(MyClass);
            MyClass.Write();
        }
        static void Print(Class myClass)
        {
            myClass = new Class("printing...");
            myClass.Write();
        }
    }
}