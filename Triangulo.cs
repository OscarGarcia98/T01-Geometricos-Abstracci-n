using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
    public class Triangulo : Figura   //Hereda de la clase Abstracta Figura
    {
        
        public override double LadoA { get; set; }
        public override double LadoB { get; set; }

        public override void GetLados(out double LadoA, out double LadoB)       //Método que obtiene los valores de los lados para calcular el Area 
        {
            Console.WriteLine("Ingrese el valor de la BASE");
            LadoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la ALTURA");
            LadoB = Convert.ToDouble(Console.ReadLine());
        }

        public override double CalcularArea(double LadoA, double LadoB)
        {
            return (LadoA * LadoB)/2;       //Retorna el Area del triangulo
        }

        public override double CalcularPerimetro(double LadoA, double LadoB)
        {
            return 0;       //Al no especificarse el tipo de triangulo se retorna 0 y no se realiza ningún cálculo.
        }


    }
}
