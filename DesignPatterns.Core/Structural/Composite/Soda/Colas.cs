using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Structural.Composite.Soda
{
    /// <summary>
    /// Leaf class
    /// </summary>
    public class VanillaCola : SoftDrink
    {
        public VanillaCola(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class StrawberryRootBeer : SoftDrink
    {
        public StrawberryRootBeer(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }

    /// <summary>
    /// Composite class
    /// </summary>
    public class Cola : SoftDrink
    {
        public Cola(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }

    /// <summary>
    /// Composite class
    /// </summary>
    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }

    /// <summary>
    /// Composite class, root node
    /// </summary>
    public class SodaWater : SoftDrink
    {
        public SodaWater(int calories , bool isAvalable) : base(calories,isAvalable) { }
    }
}
