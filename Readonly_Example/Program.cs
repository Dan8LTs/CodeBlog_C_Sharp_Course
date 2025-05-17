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

            var my = new Class("main");
            Print(ref my);
            my.Write();
        }
        static void Print(Class myClass)
        {
            myClass = new Class("printing...");
            myClass.Write();
        }
        static void Print(ref Class myClass)
        {
            myClass = new Class("ref printing...");
            myClass.Write();
        }
    }
}