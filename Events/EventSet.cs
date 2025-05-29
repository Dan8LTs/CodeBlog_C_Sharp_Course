namespace Events
{
    // такая структура нужна при большом количестве событий, тогда доступ работает за O(1), иначе O(n)
    public class EventKey { }
    internal class EventSet
    {
        private readonly Dictionary<EventKey, Delegate> events = new Dictionary<EventKey, Delegate>();
        public void Add(EventKey eventKey, Delegate handler)
        {
            Monitor.Enter(events);
            if (events.TryGetValue(eventKey, out var d))
            {
                events[eventKey] = Delegate.Combine(d, handler);
            }
            else
            {
                events.Add(eventKey, handler);
            }
            Monitor.Exit(events);
        }

        public void Remove(EventKey eventKey, Delegate handler)
        {
            Monitor.Enter(events);
            if (events.TryGetValue(eventKey, out var d))
            {
                d = Delegate.Remove(d, handler);
                if (d != null)
                {
                    events[eventKey] = d;
                }
                else
                {
                    events.Remove(eventKey);
                }
            }
            Monitor.Exit(events);
        }

        public void Raise(EventKey eventKey, object sender, EventArgs e)
        {
            Monitor.Enter(events);
            if (events.TryGetValue(eventKey, out var d))
            {
                d.DynamicInvoke(new object[] { sender, e });
            }
            Monitor.Exit(events);
        }
    }
}
