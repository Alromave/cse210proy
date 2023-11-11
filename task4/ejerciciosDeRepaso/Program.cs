// See https://aka.ms/new-console-template for more information
using System;
namespace Ejercicio
{
     class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //creacion de objeto de tipo circulo
            miCirculo = new Circulo(); //iniciacion de variable/objeto de tipo Circulo.
        //Significa tambien instanciar una clase
            Console.WriteLine(miCirculo.calculoArea(5));
            Circulo miCirculo2 = new Circulo();
            Console.WriteLine(miCirculo2.calculoArea(9));
        }
    }
    class Circulo
    {
        double pi = 3.141516; //propiedad de la clase Circulo. Campo de clase
        public double calculoArea(int radio) //metodo de clase (que es lo que debe hacer)
        {
            return pi * radio * radio;
        }
    }
        
}



