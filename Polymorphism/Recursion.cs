namespace Polymorphism
{
    internal class Recursion
    {
        // "callvirt" causes recursion
        // but CLR uses "call"
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
