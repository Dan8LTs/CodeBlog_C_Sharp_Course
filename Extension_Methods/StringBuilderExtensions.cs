using System.Text;

namespace Extension_Methods
{
    internal static class StringBuilderExtensions
    {
        public static int IndexOf(this StringBuilder sb, char v)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == v)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
