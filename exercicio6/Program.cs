using System;

namespace exercicio6
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

        // Soma das diagonais (principal e secundária)
        static void SomaDiagonal(int[,] matrizC)
        {
            int somaPrincipal = 0, somaSecundaria = 0, c = 0;
            // Principal
            for(int l = 0; l < matrizC.GetLength(0); l++){
                for (c = 0; c < matrizC.GetLength(1); c++){
                    if(l == c){
                        somaPrincipal += matrizC[l,c];
                    }
                }
            }

        // Secundaria
        c = matrizC.GetLength(1) - 1;
        for(int l = 0; l < matrizC.GetLength(0); l++){
            somaSecundaria += matrizC[l,c];
            c--;
        }
        Console.Write("\nA soma da diagonal principal é {0}\n", somaPrincipal);
        Console.Write("A soma da diagonal secundária é {0}\n", somaSecundaria);
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

        // Função que imprime matriz invertida
        static void ImprimeMatrizInvertida(int [,]matrizC)
        {
            int [,] matrizD = new int [matrizC.GetLength(0), matrizC.GetLength(1)];
            for(int l = 0; l < matrizC.GetLength(0); l++){
                for (int c = 0; c < matrizC.GetLength(1); c++){
                    matrizD[c,l] = matrizC[l,c];
                }
            }
            ImprimeMatriz(matrizD);
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

            SomaDiagonal(matrizC);

            Console.WriteLine("Matriz C transposta");
            ImprimeMatrizInvertida(matrizC);
        }
    }
}

