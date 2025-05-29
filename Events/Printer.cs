namespace Events
{
    internal class Printer
    {
        public Printer(MailManager mailManager)
        {
            mailManager.NewMail += OnNewMailEvent;
        }

        private void OnNewMailEvent(object? sender, NewMailEventArgs e)
        {
            Console.WriteLine($"Printing message: {e.Text}");
        }
        public void Unregister(MailManager mailManager)
        {
            mailManager.NewMail -= OnNewMailEvent;
        }
    }
}
