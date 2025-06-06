namespace Interfaces
{
    public interface IWindow
    {
        void GetMenu();
    }
    public interface IRestaurant
    {
        void GetMenu()
        {
            Console.WriteLine("IRestaurant.GetMenu() - default implementation");
        }
    }

    internal class Pizzeria : IWindow, IRestaurant
    {
        void IWindow.GetMenu()
        {
            Console.WriteLine("IWindow.GetMenu()");
        }
        void IRestaurant.GetMenu()
        {
            Console.WriteLine("IRestaraunt.GetMenu()");
        }
        public void GetMenu()
        {
            Console.WriteLine("Pizzeria.GetMenu()");
        }
    }

    internal class ShawarmaShop : IRestaurant { }
    internal class BurgerBar : IRestaurant
    {
        void IRestaurant.GetMenu()
        {
            Console.WriteLine("BurgerBar.GetMenu() - explicit implementation");
        }
    }
    internal class SushiBar : IRestaurant
    {
        public void GetMenu()
        {
            Console.WriteLine("SushiBar.GetMenu() - own implementation");
        }
    }
}
