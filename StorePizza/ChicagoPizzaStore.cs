using PizzaStoreFactoryMethod.ChicagoStylePizza;
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
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            if (pizzaType == "Cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (pizzaType == "Clamm")
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (pizzaType == "Pepperoni")
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (pizzaType == "Vaggie")
            {
                pizza = new ChicagoStyleVaggiePizza();
            }
            else
            {
                Console.WriteLine("No se encontró ninguna pizza de ese tipo");
            }
            return pizza;
        }
    }
}
