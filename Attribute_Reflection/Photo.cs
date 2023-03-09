
namespace Attrubute__Reflection
{//TODO: Geo create date for class GeoAttribute

    class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }

        public Photo(string name)
        {
            Name = name;
        }
    }
}
