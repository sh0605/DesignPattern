using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public abstract override string GetDescription();
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage b)
        {
            beverage = b;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 모카";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }

    public class Milk : CondimentDecorator
    {
        public Milk(Beverage b)
        {
            beverage = b;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 우유";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
    
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage b)
        {
            beverage = b;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 두유";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage b)
        {
            beverage = b;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 휘핑크림";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
