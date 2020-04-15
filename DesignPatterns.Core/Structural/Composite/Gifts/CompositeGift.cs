using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Structural.Gifts
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly List<GiftBase> _gifts;

        public CompositeGift(string name, int price)
            : base(name, price)
        {
            _gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            _gifts.Remove(gift);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{name} contains the following products with prices:");

            _gifts.ForEach(x => total += x.CalculateTotalPrice());

            return total;
        }
    }
}
