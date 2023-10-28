using PizzaStoreFactoryMethod.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.StorePizza
{
    //Clase abstracta
    public abstract class PizzaStore
    {
        //Bañuelos Hernandez María Guadalupe 19211600
         
        //Metodo abstracto para crear una pizza
        public abstract Pizza CreatePizza(string pizzaType);

        public void OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType); //Llama al factoryMethod

            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }
            else
            {
                Console.WriteLine("No se encontró una pizza coincidente en la tienda.");
            }
        }
    }
}
