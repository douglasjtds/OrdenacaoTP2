using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleOrdenacaoTP2.minhaImplementacao
{
    public class Quicksort
    {
        public static int numeroDeComparacoes = 0;
        public static int numeroDeAtribuicoes = 0;
        public static Stopwatch stopWatch = new Stopwatch();

        public void Ordena(int[] vetor, int inicio, int fim)
        {
            stopWatch.Start();

            if (inicio < fim)
            {
                int posicaoPivo = Separar(vetor, inicio, fim);
                Ordena(vetor, inicio, posicaoPivo - 1);
                Ordena(vetor, posicaoPivo + 1, fim);
            }

        }

        public static int Separar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor[i] <= pivo)
                    i++;
                else if (pivo < vetor[f])
                    f--;
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor[inicio] = vetor[f];
            vetor[f] = pivo;

            Imprimir(vetor);
            return f;
        }

        public static void Imprimir(int[] vetor)
        {
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine(vetor[k]);
            }

            stopWatch.Stop();
            Console.ReadKey();
            Console.Write("\nTempo total levado para o cálculo:  {0} milisegundos", stopWatch.ElapsedMilliseconds); //System.currentTimeMillis()
            Console.Write("\nO número de comparações é: {0}", numeroDeComparacoes);
            Console.Write("\nO número de atribuições é: {0}", numeroDeAtribuicoes);
            Console.ReadKey();
            //Thread.Sleep(4000);
        }
    }
}