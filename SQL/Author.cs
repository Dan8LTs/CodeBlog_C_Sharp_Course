using System.Collections.Generic;

namespace SQL
{
    public class Author
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
