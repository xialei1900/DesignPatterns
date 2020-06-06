using System;

namespace Command
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onLoad;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }
        public void SetOnLoad(ICommand command)
        {
            _onLoad = command;
        }
        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        public void DoSomethingImport()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");
            if (this._onLoad is ICommand)
            {
                this._onLoad.Execute();
            }

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}