using System;

namespace CP2
{
    public class Argument
    {
        public string Name;
        public char? Shortname;
        public Type? ArgumentType;
        public Delegate TargetMethod;

        public Argument(string name, char shortname, Type argumentType, Delegate targetMethod)
        {
            Name = name;
            Shortname = shortname;
            ArgumentType = argumentType;
            TargetMethod = targetMethod;
        }
        public Argument(string name, Type argumentType, Delegate targetMethod)
        {
            Name = name;
            Shortname = null;
            ArgumentType = argumentType;
            TargetMethod = targetMethod;
        }
        public Argument(string name, char shortname, Delegate targetMethod)
        {
            Name = name;
            Shortname = shortname;
            ArgumentType = null;
            TargetMethod = targetMethod;
        }
        public Argument(string name, Delegate targetMethod)
        {
            Name = name;
            Shortname = null;
            ArgumentType = null;
            TargetMethod = targetMethod;
        }

        public override string ToString()
        {
            if (ArgumentType == null)
            {
                return $"Argument {Name} ({Shortname}), Hasn't an argument, Calls {TargetMethod} function.";
            }
            return $"Argument {Name} ({Shortname}), Has an argument ({ArgumentType}), Calls {TargetMethod} function.";
        }
    }
}