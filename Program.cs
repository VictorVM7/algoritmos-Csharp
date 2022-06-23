using System;

namespace exercicio1
{
    class Program
    {   
        // Função que lê matriz
        static void LeMatriz(int [,]M)
        {
            for (int l = 0; l < M.GetLength(0); l++){
                for (int c = 0; c < M.GetLength(1); c++){
                    Console.Write("Posição {0}:{1} -> ", l+1, c+1);
                    M[l, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Função que imprime matriz
        static void ImprimeMatriz(int [,]M)
        {
            for(int l = 0; l < M.GetLength(0); l++){
                for (int c = 0; c < M.GetLength(1); c++){
                    Console.Write(M[l,c] + "\t");
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            int [,] matrizM = new int[4,4];
            LeMatriz(matrizM);
            ImprimeMatriz(matrizM);
        }
    }
}
