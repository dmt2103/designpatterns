using System;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bubbleTea = new BubbleTea();

            var pearl = new PearlBubbleTea();
            var cheese = new CheeseBubbleTea();

            Console.WriteLine(cheese.Type());
            Console.WriteLine("Price = " + cheese.Price());
            Console.ReadLine();
        }
    }

    // Base interface
    public interface IBubbleTea
    {
        string Type();
        int Price();
    }

    // Concrete implementation
    public class BubbleTea : IBubbleTea
    {
        public virtual string Type()
        {
            return "Bubble tea";
        }

        public virtual int Price()
        {
            return 100;
        }
    }

    public class PearlBubbleTea : BubbleTea
    {
        public override string Type()
        {
            var type = base.Type();
            type += "\n + boba pearls";
            return type;
        }

        public override int Price()
        {
            var price = base.Price();
            price += 20;
            return price;
        }
    }

    public class CheeseBubbleTea : BubbleTea
    {
        public override string Type()
        {
            var type = base.Type();
            type += "\n + cheese";
            return type;
        }

        public override int Price()
        {
            var price = base.Price();
            price += 25;
            return price;
        }
    }
}