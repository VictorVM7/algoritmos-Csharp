using System;

namespace exercicio2
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

        // Função que vê maior número
        static void MaiorElemento(int [,]matriz, string nomeMatriz)
        {
            int MaiorElemento = 0, linhaMaior = 0, colunaMaior = 0;
            for(int l = 0; l < matriz.GetLength(0); l++){
                for (int c = 0; c < matriz.GetLength(1); c++){
                    if (l == 0 && c == 0){
                        MaiorElemento = matriz[l,c];
                        linhaMaior = l;
                        colunaMaior = c;
                    }
                    else{
                        if (matriz[l,c] > MaiorElemento){
                            MaiorElemento = matriz[l,c];
                            linhaMaior = l;
                            colunaMaior = c;
                        }
                    }
                }     
            }
            Console.Write("O maior elemento da matriz {0} foi o {1} na posição {2}:{3}", nomeMatriz, MaiorElemento, linhaMaior, colunaMaior);
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            int [ , ] matrizA = new int [4,4];
            int [ , ] matrizB = new int [4,4];
            
            LeMatriz(matrizA);
            LeMatriz(matrizB);
            MaiorElemento(matrizA, "A");
            MaiorElemento(matrizB, "B");
        }
    }
}
