using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person
    {
        public string SecondName { get; set; }
        public string Name { get; set; }

        public Person(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;
        }
        //public string FullName
        //{
        //    get
        //    {
        //        return SecondName + " " + Name;
        //    }  
        //}
        //public string ShortName
        //{
        //    get
        //    {
        //        return $"{SecondName}.{Name.Substring(0, 1)}.";
        //    }
        //}
        /*private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                   {
                            throw new ArgumentNullException("Имя не может быть пустым");
                   }
                    _name = value;
            }
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым");
            }
            _name = name;
        }*/
    }
}
