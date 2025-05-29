namespace Events
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mailManager = new MailManager();
            // подписка на событие
            mailManager.NewMail += MailManagerNewMail;
            // отписка от события
            mailManager.NewMail -= MailManagerNewMail;

            var sms = new Sms();
            mailManager.NewMail += sms.MmNewMail;

            Console.WriteLine("Enter your name: ");
            var sender = Console.ReadLine();
            Console.WriteLine("Enter the name of the recipient of your message: ");
            var target = Console.ReadLine();
            Console.WriteLine("Enter text of your message: ");
            var text = Console.ReadLine();
            mailManager.SimulateNewMail(sender, target, text);


            Console.WriteLine();

            //System.ComponentModel.EventHandlerList использует список, небезопасный

            var typeWithManyEvents = new TypeWithManyEvents();
            typeWithManyEvents.Foo += TypeWithManyEvents_Foo;
            typeWithManyEvents.SimulateFoo();
        }

        private static void TypeWithManyEvents_Foo(object? sender, FooEventArgs e)
        {
            Console.WriteLine("FOO!");
        }

        private static void MailManagerNewMail(object sender, NewMailEventArgs e)
        {
            //var printer = new Printer();
        }
    }
}