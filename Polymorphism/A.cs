namespace Polymorphism
{
    // sealed - cannot be inherited
    // abstract - no instance
    // virtual - can be overridden
    // new - hiding

    /*
        An abstract class cannot be instantiated
        Abstract methods do not have a body and require mandatory implementation in inheritors.
        A class containing at least one abstract method must be declared as abstract.
    */
    internal abstract class A
    {
        protected int i = 0;
        protected int j = 0;

        public virtual int Prop { get; set; }
        public abstract void Update();
        protected void Method()
        {
            Console.WriteLine();
        }
    }
}
