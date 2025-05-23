namespace Properties
{
    internal class Person
    {
        private string name;
        private int age;

        // автосвойства
        public string Profession { get; set; }

        // get и set - методы аксессоры для доступа к приватным полям
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.name = name;
            }
            else
            {
                throw new ArgumentNullException("name is empty");
            }
        }

        // упрощённое создание аксессоров
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("age is incorrect");
                }
            }
        }
        public int YearOfBirth
        {
            get
            {
                return DateTime.Now.Year - age;
            }
        }

        public Person() { }
        public Person(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.name = name;
            }
            else
            {
                throw new ArgumentNullException("name is empty");
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}