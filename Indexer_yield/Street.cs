using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Indexer_yield
{
    class Street : IEnumerable
    {
        private List<House> _houses = new List<House>();
        private const int MaxHouse = 100;
        public House this[string number]
        {
            get
            {
                var house = _houses.FirstOrDefault(c => c.Name == number);
                return house;
            }
        }

        public House this[int position]
        {
            get
            {

                if (position < _houses.Count)
                {
                    return _houses[position];

                }
                return null;
            }
            set
            {
                if (position < _houses.Count)
                {
                    _houses[position] = value;
                }
            }
        }
        public int Count => _houses.Count;
        public string Name { get; set; }

        public int Add(House house)
        {
            #region Add
            if (house == null)
            {
                throw new ArgumentNullException(nameof(house), "Where");

            }
            if (_houses.Count < MaxHouse)
            {
                _houses.Add(house);
                return _houses.Count - 1;
            }
            return -1;
            #endregion
        }

        public void GoOut(string number)
        {
            #region GoOut
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "number is null");
            }
            var house = _houses.FirstOrDefault(c => c.Name == number);
            if (house != null)
            {
                _houses.Remove(house);
            }
            #endregion
        }
        public IEnumerator<int> GetNumbers(int max)
        {
            var current = 0;
            for (int i = 0; i < 10; i++)
            {
                current += i;
                yield return current;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var house in _houses)
            {
                yield return house;
            }
        }
        public IEnumerable GetNames()
        {
            foreach (var house in _houses)
            {
                yield return house.Name;
            }
        }
    }
}
