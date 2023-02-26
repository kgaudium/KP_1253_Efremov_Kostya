using System;

namespace CP
{
    public class Argument
    {
        public string Name;
        public char? Shortname;
        public bool HaveArgument;
        public Type ArgumentType;
        public Delegate TargetMethod;

        public Argument(string name, char shortname, bool haveArgument, Type argumentType, Action<int> targetMethod)
        {
            Name = name;
            Shortname = shortname;
            HaveArgument = haveArgument;
            ArgumentType = argumentType;
            TargetMethod = targetMethod;
        }
        public Argument(string name, bool haveArgument, Type argumentType, Action<int> targetMethod)
        {
            Name = name;
            Shortname = null;
            HaveArgument = haveArgument;
            ArgumentType = argumentType;
            TargetMethod = targetMethod;
        }

        public override string ToString()
        {
            string haveArg = HaveArgument ? "Has an argument" : "Hasn't an argument";
            return $"Argument {Name} ({Shortname}), {haveArg} ({ArgumentType}), calls {TargetMethod} function.";
        }
    }
}