namespace Tharga.Toolkit.Console.Command.Base
{
    class Variable
    {
        public string Name { get; private set; }
        public object Value { get; set; }

        public Variable(string name)
        {
            Name = name;
        }
    }
}