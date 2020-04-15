using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns.Core.Structural.Composite.Soda
{
    public class SoftDrink
    {
        public int Calories { get; set; }
        public bool IsAvaliable { get;}
        public List<SoftDrink> Flavors { get; set; }

        public SoftDrink(int calories, bool isAvalable)
        {
            IsAvaliable = isAvalable;
            Calories = calories;
            Flavors = new List<SoftDrink>();
        }

        public void DisplayCalories()
        {
            Console.WriteLine(GetType().Name + ": " + this.Calories.ToString() + " calories.");
            Flavors.ForEach(drink => drink.DisplayCalories());
        }

        public void ShowCumulativeCalories()
        {
            var totalCalories = default(int);
            Flavors.ForEach(x => totalCalories += x.Calories);
        }
    }
}
