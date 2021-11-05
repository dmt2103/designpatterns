﻿using System;

namespace Decorator.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Decorator design pattern
            IBubbleTea bubbleTea = new BubbleTea();

            IBubbleTea pearl = new PearlDecorator(bubbleTea);
            IBubbleTea cheese = new CheeseDecorator(pearl);
            IBubbleTea jelly = new JellyDecorator(cheese);
            IBubbleTea pudding = new PuddingDecorator(jelly);

            Console.WriteLine(pudding.Type());
            Console.WriteLine("Price = " + pudding.Price());
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
        public string Type()
        {
            return "Bubble tea";
        }

        public int Price()
        {
            return 100;
        }
    }

    // Base Decorator class
    public class BubbleTeaDecorator : IBubbleTea
    {
        private IBubbleTea _bubbleTea;

        public BubbleTeaDecorator(IBubbleTea bubbleTea)
        {
            _bubbleTea = bubbleTea;
        }

        public virtual string Type()
        {
            return _bubbleTea.Type();
        }

        public virtual int Price()
        {
            return _bubbleTea.Price();
        }
    }

    // concrete decorators
    public class PearlDecorator : BubbleTeaDecorator
    {
        public PearlDecorator(IBubbleTea bubbleTea) : base(bubbleTea) { }

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

    public class CheeseDecorator : BubbleTeaDecorator
    {
        public CheeseDecorator(IBubbleTea bubbleTea) : base(bubbleTea) { }

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

    public class JellyDecorator : BubbleTeaDecorator
    {
        public JellyDecorator(IBubbleTea bubbleTea) : base(bubbleTea) { }

        public override string Type()
        {
            var type = base.Type();
            type += "\n + jelly";
            return type;
        }

        public override int Price()
        {
            var price = base.Price();
            price += 40;
            return price;
        }
    }

    public class PuddingDecorator : BubbleTeaDecorator
    {
        public PuddingDecorator(IBubbleTea bubbleTea) : base(bubbleTea) { }

        public override string Type()
        {
            var type = base.Type();
            type += "\n + egg pudding";
            return type;
        }

        public override int Price()
        {
            var price = base.Price();
            price += 10;
            return price;
        }
    }
}