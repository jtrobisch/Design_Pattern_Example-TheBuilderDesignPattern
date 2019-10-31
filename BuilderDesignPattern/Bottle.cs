using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Bottle:Packing
    {
        public String pack()
        {
            return "Bottle";
        }
    }
    public abstract class ColdDrink:Item
    {
        public Packing packing() {
            return new Bottle();
        }
        public abstract float price();
        public abstract string name();
    }

    public class Coke : ColdDrink
    {
        public override float price() {
            return 30.0f;
        }
        public override String name() {
            return "Coke";
        }
    }
    public class Pepsi : ColdDrink
    {
        public override float price()
        {
            return 20.3f;
        }
        public override String name()
        {
            return "Pepsi";
        }
    }


}
