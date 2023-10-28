using PizzaStoreFactoryMethod.StorePizza;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "PizzaStore FactoryMethod";
            //Creacion de instancias de la tienda
            PizzaStore nyPizzaStore = new NYPizzaStore();
            PizzaStore chPizzaStore = new ChicagoPizzaStore();      //Bañuelos Hernandez María Guadalupe    19211600

            Console.WriteLine("Bienvenido a la pizzería Bañuelos");
            Console.WriteLine("Elija un estilo de pizza: ");
            Console.WriteLine("1. Estilo de Nueva York");
            Console.WriteLine("2. Estilo de Chicago");
            Console.Write("¿Que pizza escogera? ");
            int opc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            if (opc ==1)
            {
                Console.WriteLine("Estilo Nueva York");
                Console.WriteLine("Elija el tipo de pizza");
                Console.WriteLine("1. Cheese");
                Console.WriteLine("2. Clamm");
                Console.WriteLine("3. Pepperoni");
                Console.WriteLine("4. Vaggie");
                Console.WriteLine("¿Qué opcion ha escogido ?");
                int opc2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();



                if (opc2 ==1)
                {
                    nyPizzaStore.OrderPizza("Cheese");
                }
                else if (opc2 == 2)
                {
                    nyPizzaStore.OrderPizza("Calmm");       //Bañuelos Hernandez María Guadalupe    19211600
                }
                else if (opc2 == 3)
                {
                    nyPizzaStore.OrderPizza("Pepperoni");
                }
                else  if (opc2 == 4)
                {
                    nyPizzaStore.OrderPizza("Vaggie");
                }
            }
            else if (opc == 2)
            {
                Console.WriteLine("Estilo Chicago");
                Console.WriteLine("Elija el tipo de pizza");
                Console.WriteLine("1. Cheese");
                Console.WriteLine("2. Clamm");
                Console.WriteLine("3. Pepperoni");
                Console.WriteLine("4. Vaggie");
                Console.WriteLine("¿Qué opcion ha escogido ?");
                int opc2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();



                if (opc2 == 1)
                {
                    chPizzaStore.OrderPizza("Cheese");
                }
                else if (opc2 == 2)
                {
                    chPizzaStore.OrderPizza("Calmm");
                }
                else if (opc2 == 3)
                {
                    chPizzaStore.OrderPizza("Pepperoni");       //Bañuelos Hernandez María Guadalupe    19211600
                }
                else if (opc2 == 4)
                {
                    chPizzaStore.OrderPizza("Vaggie");
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida...");
            }
            Console.ReadKey();
        }
    }
}
