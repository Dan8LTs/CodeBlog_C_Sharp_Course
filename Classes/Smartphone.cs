namespace classes
{
    class Smartphone : Phone
    {
        public Smartphone(string name, int power, int price) : base(name, power, price)
        {

        }
        public static Smartphone operator +(Smartphone smartphone1, Smartphone smartphone2)
        {
            int power = smartphone1.Power + smartphone2.Power;
            var price = smartphone1.Price + smartphone2.Price;
            var smart = new Smartphone("smartphone", power, price);

            return smart;
        }
        //public Smartphone(int power, int price, int cameramp)
        //{
        //    Power = power;
        //    Price = price;
        //    CameraMP = cameramp;
        //}
    }
}
