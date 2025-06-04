namespace Generics
{
    // TFromClass - тип-параметр класса
    internal class MyClass<TFromClass>
    {
        // TFromMethod - тип-параметр метода
        public void GenericMethod<TFromMethod>(TFromClass arg1, TFromMethod arg2) { }
    }

    class Class3<TClass>
    {
        public void Method<TMethod>(TClass arg1, TMethod arg2) { }
    }
}
