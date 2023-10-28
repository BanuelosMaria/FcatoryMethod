using PizzaStoreFactoryMethod.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.NYStylePizza
{
    //Bañuelos Hernandez María Guadalupe    19211600
    // Clases concretas NYSTyle
    public class NYStyleCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparando pizza de queso estilo Nueva York");

        }
    }
}
