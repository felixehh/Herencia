using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            Animal elefante = new Animal();

            delfin.Nombre = "Delfin";
            elefante.Nombre = "Elefante";

            delfin.Comer();

            Console.ReadLine();
        }
    }
}
