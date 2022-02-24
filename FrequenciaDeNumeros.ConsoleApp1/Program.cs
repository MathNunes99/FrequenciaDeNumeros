using System;

namespace FrequenciaDeNumeros.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frequencia de Numeros!");

            int[] frequencia = new int[] {1,1,1,2,2,2, 7, 8, 10, 8, 260, 4, 10, 10 };
            Array.Sort(frequencia);

            int repet = 1;
            int i = 0;
            while (i < frequencia.Length)
            {
                if (i == frequencia.Length-1)
                {
                    repet = 1;
                    Console.WriteLine(frequencia[i] + " Repete " + repet + " vezes!");
                    break;
                }
                else
                {
                    while (frequencia[i] == frequencia[i + 1])
                    {
                        i++;
                        repet++;
                    }
                }
                
                Console.WriteLine(frequencia[i] + " Repete " + repet + " vezes!");
                repet = 1;
                i++;
            }
            Console.ReadLine();

        }
    }
}
