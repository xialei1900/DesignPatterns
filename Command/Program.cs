using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            invoker.SetOnLoad(new SimpleCommand("I'm Loading..."));
            invoker.SetOnFinish(new ComplexCommand(new Receiver(), "Send email", "Save report"));

            invoker.DoSomethingImport();
        }
    }
}
