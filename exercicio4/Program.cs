using System;

namespace exercicio4
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
        
        // Média matriz
        static void MediaMatriz(int[,]matriz, string nomeMatriz)
        {
            int soma = 0;
            double media;
            for (int l = 0; l < matriz.GetLength(0); l++){
                for (int c = 0; c < matriz.GetLength(1); c++){
                    soma = soma + matriz[l,c];
                }
            }
            media = soma / (matriz.GetLength(0) * matriz.GetLength(1));
            Console.Write("A média da matriz {0} é {1}", nomeMatriz, media);
            Console.Write("\n");
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

            LeMatriz(matrizA);
            LeMatriz(matrizB);

            MediaMatriz(matrizA, "A");
            MediaMatriz(matrizB, "B");        
        }
    }
}
