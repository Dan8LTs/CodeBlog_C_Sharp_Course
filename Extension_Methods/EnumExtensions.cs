namespace Extension_Methods
{
    internal static class EnumExtensions
    {
        public static void Print<T>(this IEnumerable<T> l)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
