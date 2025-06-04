using System.Collections;

namespace Generics
{
    internal static class Tests
    {
        internal static void ValueTypePerf(int count)
        {
            using (new OperationTimer("List<int>"))
            {
                var list = new List<int>();
                for (var i = 0; i < count; i++)
                {
                    list.Add(i);
                    var x = list[i];
                }
                list = null;
            }
            using (new OperationTimer("ArrayList of int"))
            {
                var array = new ArrayList();
                for (var i = 0; i < count; i++)
                {
                    array.Add(i);
                    var x = (int)array[i];
                }
                array = null;
            }
        }

        internal static void ReferenceTypePerf(int count)
        {
            using (new OperationTimer("List<string>"))
            {
                var list = new List<string>();
                for (var i = 0; i < count; i++)
                {
                    list.Add("X");
                    var x = list[i];
                }
            }
            using (new OperationTimer("ArrayList of string"))
            {
                var array = new ArrayList();
                for (var i = 0; i < count; i++)
                {
                    array.Add("X");
                    var x = (string)array[i];
                }
                array = null;
            }
        }
    }
}
