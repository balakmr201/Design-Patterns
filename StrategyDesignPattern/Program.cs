using System;

namespace StrategyDesignPattern
{
    public interface IStrategy
    {
        object Area(object data);
    }
    public class Context
    {
        private IStrategy strategy;
        public Context()
        {

        }
        public Context(IStrategy strategy)
        {
            this.strategy = strategy; 
        }
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void DoSomething()
        {
            this.strategy.Area(strategy.GetType().ToString());
        }
    }
    public class ContextA : IStrategy
    {
        public object Area(object data)
        {
            var t = data as string;
            Console.WriteLine("Hello from "+t);

            return t;
        }
    }
    public class ContextB : IStrategy
    {
        public object Area(object data)
        {
            var t = data as string;
            Console.WriteLine("Hello from " + t);

            return t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Context a = new Context();
            a.SetStrategy(new ContextA());
            a.DoSomething();

            a.SetStrategy(new ContextB());
            a.DoSomething();

            Console.ReadKey();
        }
    }
}
