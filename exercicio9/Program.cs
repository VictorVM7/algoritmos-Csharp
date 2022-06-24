using System;

namespace exercicio9
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
        // Soma das diagonais (principal e secundária)
        static void ImprimePrincipal(int[,] matriz)
        {
            for(int l = 0; l < matriz.GetLength(0); l++){
                for (int c = 0; c < matriz.GetLength(1); c++){
                    if(c >= l){
                        Console.Write(matriz[l,c] + "\t");
                    }
                    else{
                        Console.Write('\t');
                    }
                }
                Console.Write("\n");
            }
            
        }


        static void Main(string[] args)
        {
            int [ , ] matrizA = new int [4,4];
            LeMatriz(matrizA);
            ImprimePrincipal(matrizA);
        }
    }
}
