using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_introduccion_c_
  
{
    public class Ejercicio3
    {
        public List<string> DiasSemana { get; set; }
        public List<string> FinSemana { get; set; }

        //constructor un constructor es un método especial dentro de una clase que se utiliza para inicializar los objetos de esa clase. Al igual que en otros lenguajes de programación orientados a objetos, el constructor se invoca automáticamente al crear una nueva instancia (objeto) de la clase y se encarga de asignar los valores iniciales a los atributos de la clase.
        public Ejercicio3() 
        {
            DiasSemana = new List<string>{"lunes","martes","miercoles","jueves","viernes" };
            FinSemana = new List<string> { "sabado","domingo" };
        }

        public bool VerificarDiaSemana(string dia) 
        {
            bool resultado = false;
            //verificar si es dia de semana 
            foreach (var item in DiasSemana)
            {
                if (dia == item)
                { 
                    resultado = true;
                    return resultado;
                }
            }
            return resultado;
        }
 
        public bool VerificarFinSemana(string dia)
        {
            bool resultado = false;
            //verificar si es fin de semana 
            foreach (var item in FinSemana)
            {
                if (dia == item)
                {
                    resultado = true;
                    return resultado;
                }
            }
            return resultado;
        }
    }
}
