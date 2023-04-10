using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04hm_stratege
{
    interface Stratege
    {
        object Drive();
    }
    class Context
    {
        private Stratege strategy;
        public Context() { }
        public Context(Stratege strategy)
        {
            this.strategy = strategy;
        }
        public void SetStrategy(Stratege strategy)
        {
            this.strategy = strategy;
        }
        public void DoSomeBusinessLogic()
        {
            var result = strategy.Drive();
            Console.WriteLine(result);
        }
    }
    class Cart : Stratege
    {
        public object Drive()
        {
            return "Rdie car";
        }
    }
    class Scuter : Stratege
    {
        public object Drive()
        {
            return "Ride scuter";
        }
    }
    class Porche : Stratege
    {
        public object Drive()
        {
            return "Ride Porche";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.SetStrategy(new Scuter());
            context.DoSomeBusinessLogic();
        }
    }
}