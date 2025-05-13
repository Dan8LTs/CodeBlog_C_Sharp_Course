namespace CompanyA
{
    internal class Phone
    {
        public void Dial()
        {
            Console.WriteLine("Phone.Dial");
            CheckConnection();
        }
        protected virtual void CheckConnection()
        {
            Console.WriteLine("ImprovedPhone.CheckConnection");
        }
    }
}
