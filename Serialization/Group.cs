using System;

namespace Serialisation
{
    [Serializable]
    public class Group
    {

        [NonSerialized]
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);

        public int Number { get; set; }
        public string Name { get; set; }

        public Group group { get; set; }
        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Group " + rnd;
        }

        public Group(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
