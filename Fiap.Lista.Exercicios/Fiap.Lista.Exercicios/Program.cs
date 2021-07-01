using System;

namespace Fiap.Lista.Exercicios
{
    class Calcular
    {
        static void Main(string[] args)
        {
            
             //Declara as variaveis x e y
             double x;
             double y;
             //Cria objeto calculadora
             Calculadora Calculadora = new Calculadora();
             // Atribui valores do usuaria a x e y
             Console.WriteLine("Por favor, digite um valor para X");
             x= double.Parse(Console.ReadLine());
             Console.WriteLine("Por favor, digite um valor para Y");
             y = double.Parse(Console.ReadLine());
            //Declara os valores nos Métodos Somar e Subtrair

            Console.WriteLine($"A soma de x+y é = {Calculadora.Somar(x, y)}");
             Console.WriteLine($"A subtração de x-y é = {Calculadora.Subtrair(x, y)}");

        }//Main
    }//Class
}//Namespace
