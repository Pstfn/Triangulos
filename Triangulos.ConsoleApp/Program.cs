using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double tipoTriangulo;
                Console.WriteLine("digite 1 para verificar o tipo do triângulo ou 2 pra sair: ");
                tipoTriangulo = Convert.ToDouble(Console.ReadLine());

                if (tipoTriangulo == 2)
                {
                    Console.WriteLine("Obrigado por usar nossos serviços, até mais!");
                    break;
                }
                else
                {
                    double valorX, valorY, valorZ;
                    Console.WriteLine("digite o valor X:");
                    valorX = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o valor Y:");
                    valorY = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o valor Z:");
                    valorZ = Convert.ToDouble(Console.ReadLine());
                    if (tipoTriangulo == 1)
                    {
                        if (valorX + valorY < valorZ || valorX + valorZ < valorY || valorY + valorZ < valorX)
                        {
                            Console.WriteLine("Triângulo Inválido");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (valorX == valorY && valorY == valorZ)
                        {
                            Console.WriteLine("Você possui um triângulo eqüilátero.");
                        }
                        else if (valorX == valorY || valorX == valorZ || valorY == valorZ)
                        {
                            Console.WriteLine("Você possui um triângulo isósceles.");
                        }
                        else if (valorX != valorY && valorX != valorZ && valorY != valorZ)
                        {
                            Console.WriteLine("Você possui um triângulo escaleno.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (valorX + valorY < valorZ || valorX + valorZ < valorY || valorY + valorZ < valorX)
                    {
                        Console.WriteLine("Triângulo Inválido");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
