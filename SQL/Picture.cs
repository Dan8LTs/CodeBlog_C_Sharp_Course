namespace SQL
{
    public class Picture
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
