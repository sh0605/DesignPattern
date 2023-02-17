using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Console.WriteLine();

            Duck model = new ModelDuck();
            model.performFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
