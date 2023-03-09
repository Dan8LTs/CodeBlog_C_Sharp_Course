namespace Extension_Method
{
    public class House
    {
        public int Number { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"House {Number}, with height = {Height}";
        }
    }

}
