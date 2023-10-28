using PizzaStoreFactoryMethod.ClaseAbstracta;
using PizzaStoreFactoryMethod.NYStylePizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.StorePizza
{
    //Bañuelos Hernandez María Guadalupe 19211600
    //Clase concreta
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == "Cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if(pizzaType == "Clamm")
            {
                pizza = new NYStyleClamPizza();
            }
            else if (pizzaType == "Pepperoni")
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (pizzaType == "Vaggie")
            {
                pizza = new NYStyleVeggiePizza();
            }
            else
            {
                Console.WriteLine("No se encontró ninguna pizza de ese tipo");
            }
            return pizza;
        }
    }
}
