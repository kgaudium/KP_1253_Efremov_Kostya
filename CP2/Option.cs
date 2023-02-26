using System;

namespace CP2
{
    public class Option
    {
        public string Name;
        public char? Shortname;
        public Type? ArgumentType;
        public Delegate TargetMethod;

        public Option(string name, char shortname, Type argumentType, Delegate targetMethod)
        {
            Name = name;
            Shortname = shortname;
            ArgumentType = argumentType;
            TargetMethod = targetMethod;
        }
        public Option(string name, Type argumentType, Delegate targetMethod)
        {
            Name = name;
            Shortname = null;
            ArgumentType = argumentType;
            TargetMethod = targetMethod;
        }
        public Option(string name, char shortname, Delegate targetMethod)
        {
            Name = name;
            Shortname = shortname;
            ArgumentType = null;
            TargetMethod = targetMethod;
        }
        public Option(string name, Delegate targetMethod)
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