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
        // Beverage에 null이 오지 않게 하려면 어떻게 해야할까?
        // 1. ref를 붙여서 null이 오지 않도록 처리한다
        // 2. 기본 객체(ex)DefaultBeverage)를 만들고, Beverage가 null인 경우 기본 객체를 할당한다?
        // 어떤 방법이 더 좋을지는 고민이 필요한 문제임
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
