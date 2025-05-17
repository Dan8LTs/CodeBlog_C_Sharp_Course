namespace Methods_Constructors
{
    internal class Class2 : Class1
    {
        public Class2() : base(8)
        {
            var c1 = new Class1();
            // при создании структуры мы не обязаны вызывать конструктор
            Struct1 st;
            // st.i = 12;
        }
    }
}