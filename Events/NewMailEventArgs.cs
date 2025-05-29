namespace Events
{
    // название класса заканчивается на EventArgs
    internal class NewMailEventArgs : EventArgs
    {
        // поля доступны только для чтения
        public string From { get; }
        public string To { get; }
        public string Text { get; }
        public NewMailEventArgs(string from, string to, string text)
        {
            From = from;
            To = to;
            Text = text;
        }
        public override string ToString()
        {
            return $"Mail from {From} to {To}: {Text}";
        }
    }
}
