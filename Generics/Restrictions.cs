namespace Generics
{
    // Нельзя делать ограничения следующих типов: Object, Array, ValueType, Void, Nullable
    // Основные ограничения
    internal sealed class PrimaryConstraintOfStream<T> where T : Stream { }
    internal sealed class PrimaryConstraintOfClass<T> where T : class //все ссылочные типы
    {
        public void M()
        {
            T temp = null;
        }
        private static void ComparingTwoGenericTypeVariables<T>(T o1, T o2) where T : class
        {
            if (o1 == o2) { }
        }
    }
    internal sealed class PrimaryConstraintOfStruct<T> where T : struct //все значимые типы
    {
        public static T Factory()
        {
            return new T();
        }
    }

    // Дополнительные ограничения 
    internal sealed class SecondaryInterfaceConstraint<T> where T : IComparable<T>, IEquatable<T>
    {
        public void Use() { }
    }
    internal sealed class InterfaceImplementor : IComparable<InterfaceImplementor>, IEquatable<InterfaceImplementor>
    {
        public int CompareTo(InterfaceImplementor? other)
        {
            throw new NotImplementedException();
        }
        public bool Equals(InterfaceImplementor? other)
        {
            throw new NotImplementedException();
        }
    }

    internal sealed class User
    {
        public void Main()
        {
            var user = new SecondaryInterfaceConstraint<InterfaceImplementor>();
            var ok = new SecondaryInterfaceConstraint<string>();
        }
    }

    internal sealed class TypeParameterConstraint
    {
        private static List<TBase> ConvertIList<T, TBase>(IList<T> list) where T : TBase
        {
            List<TBase> baseList = new List<TBase>(list.Count);
            for (int index = 0; index < list.Count; index++)
            {
                baseList.Add(list[index]);
            }
            return baseList;
        }
        private static void CallingConvertIList()
        {
            IList<string> ls = new List<string>();
            ls.Add("A String");

            IList<object> lo = ConvertIList<string, object>(ls);

            IList<IComparable> lc = ConvertIList<string, IComparable>(ls);

            IList<IComparable<string>> lcs = ConvertIList<string, IComparable<string>>(ls);

            IList<string> ls2 = ConvertIList<string, String>(ls);
        }
    }

    // new() проверяет наличие конструктора без параметров
    internal sealed class ConstructorConstraint<T> where T : new()
    {
        public static T Factory()
        {
            return new T();
        }
    }
    internal sealed class Casting
    {
        private static void CastingAGenericTypeVariable<T>(T obj)
        {
            // string s = (string)(object)obj;
            string s = obj as string;
        }

        private static void SettingAGenericTypeVariableToNull<T>()
        {
            T temp = default(T);
        }
    }
}
