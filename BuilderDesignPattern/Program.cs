using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Builder pattern builds a complex object using simple objects 
            //and using a step by step approach. This type of design pattern comes 
            //under creational pattern as this pattern provides one of the best ways 
            //to create an object.
            //A Builder class builds the final object step by step.This builder is 
            //independent of other objects.

            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total Cost: " + vegMeal.getCost());

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal");
            nonVegMeal.showItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.getCost());

            Console.ReadLine();
        }
    }
}
