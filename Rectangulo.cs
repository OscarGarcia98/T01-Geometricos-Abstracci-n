using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
   public class Rectangulo : Figura   //Hereda de la clase Abstracta Figura
    {
       
        public override double LadoA { get; set; }
        public override double LadoB { get; set; }

        public override void GetLados(out double LadoA, out double LadoB)       //En este caso si requiero utilizar ambos atributos 
        {
            Console.WriteLine("Ingrese el valor de la BASE");
            LadoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la ALTURA");
            LadoB = Convert.ToDouble(Console.ReadLine());
        }
        public override double CalcularArea(double LadoA, double LadoB)
        {
            return LadoA * LadoB;   //Retorna el Area del rectangulo
        }

        public override double CalcularPerimetro(double LadoA, double LadoB)
        {
            return (LadoA + LadoB) * 2;     //Retorna el Perimetro del rectangulo.
        }

    }
}
