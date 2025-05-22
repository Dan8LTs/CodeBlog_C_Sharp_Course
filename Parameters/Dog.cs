namespace Parameters
{
    internal class Dog
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}