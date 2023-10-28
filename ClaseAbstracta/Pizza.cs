using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreFactoryMethod.ClaseAbstracta
{
    //Clase abstracta de Pizza
    public abstract class Pizza
    {
        public abstract void Prepare();
        public void Bake()
        {
            Console.WriteLine("Horneando pizza durante 12 minutos a 400 grados");
        }
        public void Cut()      //Bañuelos Hernandez María Guadalupe    19211600

        {
            Console.WriteLine("Cortando la pizza en pedazos");

        }
        public void Box()
        {
            Console.WriteLine("Empaquetando la pizza");
            Console.WriteLine("Bañuelos Hernandez María guadalupe   19211600");

        }
    }
}
