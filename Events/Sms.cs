namespace Events
{
    internal class Sms
    {
        public void MmNewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine($"{sender} {e.From}");
        }
        public void Send(string message)
        {
            Console.WriteLine($"Sending sms: {message}");
        }
    }
}
