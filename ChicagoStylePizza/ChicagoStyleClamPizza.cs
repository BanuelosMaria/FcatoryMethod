using PizzaStoreFactoryMethod.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.ChicagoStylePizza
{
    public class ChicagoStyleClamPizza : Pizza
    {
        //Bañuelos Hernandez María Guadalupe    19211600
        // Clases concretas ChicagoTyle

        public override void Prepare()
        {
            Console.WriteLine("Preparando pizza de almeja estilo Chicago");
        }
    }
}
