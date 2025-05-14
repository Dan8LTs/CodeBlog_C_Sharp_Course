// Static class cannot be instantiated, all of its members must be static, and it does not support inheritance.

namespace Static
{
    internal static class StaticClass
    {
        // Constructor cannot take parameters
        static StaticClass() { }
        static void StaticMethod() { }
        static string StaticField;
        static string StaticProperty
        {
            get { return StaticField; }
            set { StaticField = value; }
        }
        static int StaticProp { get; set; }
        static event EventHandler StaticEvent;
    }
}
