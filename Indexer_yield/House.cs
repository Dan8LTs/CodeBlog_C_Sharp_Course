namespace Indexer_yield
{
    class House
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return Name + " " + Number;
        }
    }
}
