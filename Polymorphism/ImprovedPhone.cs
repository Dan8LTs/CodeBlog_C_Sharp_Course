
namespace CompanyB
{
    internal class ImprovedPhone : CompanyA.Phone
    {
        protected override void CheckConnection()
        {
            Console.WriteLine("ImprovedPhone.CheckConnection");
        }
    }
}
