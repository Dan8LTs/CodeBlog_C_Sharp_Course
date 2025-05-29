using System.Collections;

namespace Properties
{
    // реализация IEnumerable позволяет использовать обращаться к экземпляру класса, как к коллекции
    internal class Community : IEnumerable
    {
        private List<Person> people = new List<Person>();
        //public List<Person> People { get { return people; } }
        public List<Person> People => people;

        public IEnumerator GetEnumerator()
        {
            foreach (Person person in people)
            {
                yield return person;
            }
        }
    }
}
