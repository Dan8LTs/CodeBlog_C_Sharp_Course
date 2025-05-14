namespace Readonly_Example
{
    internal class Class
    {
        public string Text;
        public Class(string text) { Text = text; }
        public void Write()
        {
            Console.WriteLine(Text);
        }
    }
}
