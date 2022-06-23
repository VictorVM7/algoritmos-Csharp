using System;

namespace exercicio3
{
    class Program
    {
        // Função que lê matriz
        static void LeMatriz(int [,]matriz)
        {
            for (int l = 0; l < matriz.GetLength(0); l++){
                for (int c = 0; c < matriz.GetLength(1); c++){
                    Console.Write("Posição {0}:{1} -> ", l+1, c+1);
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\n");
        }
        
        // Soma as matrizes
        static void SomaMatriz(int[,]matrizA, int[,]matrizB, int[,]matrizC)
        {
            for (int l = 0; l < matrizA.GetLength(0); l++){
                for (int c = 0; c < matrizA.GetLength(1); c++){
                    matrizC[l,c] = matrizA[l,c] + matrizB[l,c];
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
            int [ , ] matrizA = new int [4,4];
            int [ , ] matrizB = new int [4,4];
            int [ , ] matrizC = new int [4,4];

            LeMatriz(matrizA);
            LeMatriz(matrizB);

            SomaMatriz(matrizA, matrizB, matrizC);

            Console.WriteLine("Soma das Matrizes A e B");
            ImprimeMatriz(matrizC);
            
        }
    }
}
