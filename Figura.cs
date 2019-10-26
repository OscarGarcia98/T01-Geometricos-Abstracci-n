using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
   public abstract class Figura     //Clase abstracta que contiene los atributos y métodos que las clases heredadas utilizarán para calcular Area y Perimetro de figuras geométricas
    {
       
        public abstract double  LadoA { get; set; }     
        public abstract double LadoB { get; set; }


        public abstract void GetLados(out double LadoA, out double LadoB);      //Método que permite obtener los valores de los lados de la figura elegida
        
        public abstract double CalcularArea(double LadoA, double LadoB); //Calcula el Area de la figura elegida

        public abstract double CalcularPerimetro(double LadoA, double LadoB);   //Calcula el Perimetro de la figura elegida
       
    }
}
