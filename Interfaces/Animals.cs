namespace Interfaces
{
    internal class AnimalBase
    {
        protected string _speech = "";
        public override string ToString()
        {
            return _speech;
        }
    }

    internal class Cat : AnimalBase
    {
        public Cat()
        {
            _speech = "Meow";
        }
    }
    internal class Dog : AnimalBase
    {
        public Dog()
        {
            _speech = "Woof";
        }
    }
}
