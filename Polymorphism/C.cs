namespace Polymorphism
{
    internal class C : B
    {
        // You can no longer override the sealed method
        public new void Update()
        {
            base.Update();
        }
    }
}
