namespace Methods_Constructors
{
    internal struct Struct1
    {
        public static int i = 16;
        public int j;

        // по умолчанию конструктор не создаётся

        // нельзя создать конструктор без параметров
        public Struct1()
        {
            // инициализация всех полей значениями по умолчанию
            this = new Struct1();
        }
    }
}
