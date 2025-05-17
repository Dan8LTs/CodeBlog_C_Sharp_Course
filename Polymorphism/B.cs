namespace Polymorphism
{
    internal class B : A
    {
        public sealed override void Update()
        {
            Console.WriteLine(i);
        }
        public override int Prop { get => base.Prop; set => base.Prop = value; }
        protected new void Method()
        {

        }
    }
}
