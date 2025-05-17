namespace Extension_Methods
{
    sealed partial class Base
    {
        private string name;
        partial void OnNameChanging(string value);
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                OnNameChanging(value.ToLower());
                name = value;
            }
        }
    }
    partial class Base
    {
        partial void OnNameChanging(string value)
        {
            throw new ArgumentNullException(nameof(value));
        }
    }
}
