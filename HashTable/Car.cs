namespace Hash_Table
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public char Category { get; set; }
        public override string ToString()
        {
            return Model;
        }
    }
}
