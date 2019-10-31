using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Wrapper:Packing
    {
        public String pack() {
            return "Wrapper";
        }
    }

    public abstract class Burger : Item
    {

        public Packing packing()
        {
            return new Wrapper();
        }
        public abstract float price();
        public abstract string name();

    }
    public class VegBurger: Burger
    {
        public override float price() {
            return 25.0f;
        }
        public override String name() {
            return "Veg Burger";
        }
    }

    public class ChickenBurger: Burger
    {
        public override float price(){
            return 20.4f;
        }
        public override String name(){
            return "Chicken Burger";
        }
    }

}
