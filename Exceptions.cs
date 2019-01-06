namespace TreehouseDefense
{
    class TreehouesDefenseException : System.Exception
    {
        public TreehouesDefenseException()
        { }
        public TreehouesDefenseException(string message) : base(message)
        { }
    }

    class OutOfBoundsException : TreehouesDefenseException
    {
        public OutOfBoundsException()
        { }
        public OutOfBoundsException(string message) : base(message)
        { }
    }

    class InvalidEntry : TreehouesDefenseException
    {
        public InvalidEntry()
        { }
        public InvalidEntry(string message) : base(message)
        { }
    }
}