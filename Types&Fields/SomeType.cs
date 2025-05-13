namespace Types_Fields
{
    internal sealed class SomeType
    {
        private class NestedType { }
        private const int SomeConst = 1;
        private readonly int SomeReadonlyInt = 2;
        private readonly int SomeStaticInt = 3;

        static SomeType() { }
        public SomeType() { }
        public SomeType(int value) { }
        private string InstanceMethod() { return null; }
        private static void StaticMethod() { }
        public void ParamMethod(params int[] items) { }
        public int Property { get; set; }
        public int SomeProperty
        {
            get { return 0; }
            set { int a = value; }
        }
        public int this[string s]
        {
            get { return 0; }
            set { }
        }
        public EventHandler SomeDelegate;
        public event EventHandler SomeEvent;
    }
}
