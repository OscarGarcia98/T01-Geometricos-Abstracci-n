using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
   public class Principal
    {
        Figura cuadrado = new Cuadrado();       //Instanciación de las figuras 
        Figura rectangulo = new Rectangulo();
        Figura triangulo = new Triangulo();
       public  Principal()      //Constructor que se ejecuta al instanciar la clase Principal en el Main 
        {
            MostrarMensaje();       //Método que muestra un saludo al iniciar el programa
            Menu();     //Método Menú que interacciona con el usuario

        }

        public void Menu()
        {
            Console.WriteLine("Elija una figura");      //El usuario ingresa el número de la figura y mediantre un switch se ejecuta los procedimientos
            Console.WriteLine("1.-Cuadrado\n" +
                "2.-Rectángulo\n" +
                "3.-Triángulo.");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    
                    cuadrado.GetLados(  out double Lado1,   out double Lado2);//Se ingresa dos variables Lado1, Lado2 a los cuales se les asignará el valor de los lados
                    cuadrado.LadoA = Lado1;     //Esos valores se guardarán en las variables de cada figura
                    cuadrado.LadoB = Lado2;
                    Console.WriteLine("Area: "+cuadrado.CalcularArea(cuadrado.LadoA, cuadrado.LadoB));      //Se muestra el Area del CUADRADO
                    Console.WriteLine("Perimetro: " + cuadrado.CalcularPerimetro(cuadrado.LadoA, cuadrado.LadoB)+"\nPulse cualquier tecla para continuar"); //Se muestra el PERIMETRO
                    break;

                case "2":
                    Console.Clear();
                    rectangulo.GetLados(out Lado1 , out Lado2); 
                    rectangulo.LadoA = Lado1;
                    rectangulo.LadoB = Lado2;
                    Console.WriteLine("Area: " + rectangulo.CalcularArea(rectangulo.LadoA, rectangulo.LadoB) ); //Muestra el Area del RECTANGULO
                    Console.WriteLine("Perimetro: "+ rectangulo.CalcularPerimetro(rectangulo.LadoA, rectangulo.LadoB ) + "\nPulse cualquier tecla para continuar");   //Muestra el Perimetro del RECTANGULO
                    break;

                case "3":
                    Console.Clear();
                    triangulo.GetLados(out Lado1, out Lado2);
                    triangulo.LadoA = Lado1;
                    triangulo.LadoB = Lado2;
                    Console.WriteLine("Area: "+triangulo.CalcularArea(triangulo.LadoA, triangulo.LadoB));   //Muestra el Area del Triangulo

                    Console.WriteLine("No se puede calcular el perímetro del triangulo\nPulse cualquier tecla para continuar.");//Se muestra un mensaje al usuario explicando que no se puede determinar el perimetro
                   
                    
                    break;
                    
            }
            Console.ReadKey();
            Console.Clear();
            Menu(); //Se vuelve a ejecutar el menú para que el usuario elija otra figura
        }


        public void MostrarMensaje()        //Mensaje de bienvenida al correr el programa
        {
            Console.WriteLine("Cálculo de áreas geométricas"); 
        }


    }
}
