namespace Methods_Constructors
{
    internal class Class1
    {
        // приводит к разрастанию кода
        int i = 6;

        int j;
        int k;

        public Class1()
        {
            // i = 6;

            j = 8;
            k = 5;
        }
        // default: public Class1() : base() { }
        public Class1(int i) : this()
        {

        }
    }
}