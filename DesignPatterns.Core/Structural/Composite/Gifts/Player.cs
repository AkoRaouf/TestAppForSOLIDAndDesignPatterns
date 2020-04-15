using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Structural.Gifts
{
    public class Player
    {
        public void DoIt()
        {
            var phone = new SingleGift("Phone", 10);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var zhilvanGif = new CompositeGift("ZhilvanGift", 0);
            var carToy = new SingleGift("carToy", 50);
            var dollToy = new SingleGift("dollToy", 75);

            zhilvanGif.Add(carToy);
            zhilvanGif.Add(dollToy);

            var carBox = new CompositeGift("CarBox", 0);
            var vanet = new SingleGift("VanetGift", 90);
            carBox.Add(vanet);

            zhilvanGif.Add(carBox);

            Console.WriteLine($"The total price of this composite present is: {zhilvanGif.CalculateTotalPrice()}");
        }
    }
}
