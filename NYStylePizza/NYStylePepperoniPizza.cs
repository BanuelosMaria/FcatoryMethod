﻿using PizzaStoreFactoryMethod.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.NYStylePizza
{
    public class NYStylePepperoniPizza : Pizza
    {
        //Bañuelos Hernandez María Guadalupe    19211600
        // Clases concretas NYSTyle

        public override void Prepare()
        {
            Console.WriteLine("Preparando pizza de peperroni estilo Nueva York");
        }
    }
}
