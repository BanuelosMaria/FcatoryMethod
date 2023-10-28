using PizzaStoreFactoryMethod.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.ChicagoStylePizza
{
    //Bañuelos Hernandez María Guadalupe    19211600
    // Clases concretas ChicagoTyle

    public class ChicagoStyleCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparando pizza de queso estilo Chicago");
        }
    }
}
