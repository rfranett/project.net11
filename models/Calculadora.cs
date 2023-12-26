using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.models
{
    public class Calculadora
    {
        public void Somar(int x, int y,int z)
        {
            Console.WriteLine($"{x} + {y} +{z}= {x+y+z}");
        }

        public void Subtrair (int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public void Multiplicar (int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x*y}");
        }

        public void Dividir (int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }

        public void potencia(int x,int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno (double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double Seno = Math.Sin(radiano);
            Console.WriteLine($"seno de {angulo}° = {Seno}");
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(Seno, 4)}");
        }

                public void Coseno (double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double Coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Coseno}");
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(Coseno, 4)}");
        }

                public void Tangente (double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double Tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Tangente}");
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(Tangente, 4)}");
        }



    
    }
}