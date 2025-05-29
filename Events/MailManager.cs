namespace Events
{
    internal class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail;
        // именование: On + название события
        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            // проверка e на null
            _ = e ?? throw new ArgumentNullException(nameof(e));

            //1) NewMail?.Invoke(this, e);
            //2) EventHandler<NewMailEventArgs> temp = NewMail;
            //    if (temp != null) temp(this, e);
            Volatile.Read(ref NewMail)?.Invoke(this, e);
        }
        public void SimulateNewMail(string from, string to, string subject)
        {
            // проверка данных

            // информация для получателей уведомления 
            var e = new NewMailEventArgs(from, to, subject);

            // метод, уведомляющий объект о событии
            OnNewMail(e);
        }
    }
}
