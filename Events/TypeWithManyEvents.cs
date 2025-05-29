namespace Events
{
    public class FooEventArgs : EventArgs { }
    internal class TypeWithManyEvents
    {
        protected EventSet EventSet { get; } = new EventSet();
        protected static readonly EventKey fooEventKey = new EventKey();
        public event EventHandler<FooEventArgs> Foo
        {
            add { EventSet.Add(fooEventKey, value); }
            remove { EventSet.Remove(fooEventKey, value); }
        }
        protected virtual void OnFoo(FooEventArgs e)
        {
            EventSet.Raise(fooEventKey, this, e);
        }
        public void SimulateFoo()
        {
            OnFoo(new FooEventArgs());
        }
    }
}
