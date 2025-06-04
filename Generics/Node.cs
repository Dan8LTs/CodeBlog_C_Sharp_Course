namespace Generics
{
    internal sealed class TypedNode<T> : Node
    {
        public T data;
        public TypedNode(T data) : this(data, null) { }
        public TypedNode(T data, Node next) : base(next)
        {
            this.data = data;
        }
        public override string ToString()
        {
            return data.ToString() + " " + next?.ToString();
        }
    }
    internal class Node
    {
        protected Node next;
        public Node(Node next)
        {
            this.next = next;
        }
    }
}
