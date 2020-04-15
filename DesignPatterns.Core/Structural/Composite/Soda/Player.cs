using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Structural.Composite.Soda
{
    public class Player
    {
        public void DoIt()
        {
            var colas = new Cola(210, true);
            colas.Flavors.Add(new VanillaCola(215, true));
            colas.Flavors.Add(new CherryCola(210, true));

            var lemonLime = new LemonLime(185, true);

            var rootBeers = new RootBeer(195, true);
            rootBeers.Flavors.Add(new VanillaRootBeer(200, true));
            rootBeers.Flavors.Add(new StrawberryRootBeer(200, true));

            SodaWater sodaWater = new SodaWater(180, true);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();

            Console.ReadKey();
        }

    }
}
