using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
   public class Cuadrado : Figura       //Hereda de la clase Abstracta Figura
    {
   
        public override double  LadoA { get; set; }    
        public override double LadoB { get; set; }

        public override void GetLados(out double  LadoA, out double  LadoB) //Como son dos valores, utilizo el tipo de salida Out para obtener los 2 lados en el metodo
        {
            Console.WriteLine("Ingrese el valor de un Lado del Cuadrado");
            LadoA = Convert.ToDouble(Console.ReadLine());
            LadoB = 0;      //En el caso del cuadrado solo necesito un LADO pero el metodo esta declarado de esta manera en la SuperClase asi que debo darle un valor cualquiera al Lado B
        }
        public override double CalcularArea(double LadoA, double LadoB)
        {
            return LadoA * LadoA;       //Retorna el area del cuadrado 
        }

        public override double CalcularPerimetro(double LadoA, double LadoB)
        {
            return LadoA * 4;       //Retorna el perimetro del cuadrado.
        }

    }
}
