using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    
   public class Profesor:Persona
    {
        public void Explicar()
        {
            Console.WriteLine("Estoy explicando");
        }

        public override void VerEdad()
        {
            Console.WriteLine($"Soy profesor y mi edad es {Edad}");
        }

    }
    
}
