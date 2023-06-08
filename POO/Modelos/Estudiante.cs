using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class Estudiante:Persona
    {
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
        public override void VerEdad()
        {
            Console.WriteLine($"Soy estudiante y mi edad es {Edad}");
        }
    }
}
