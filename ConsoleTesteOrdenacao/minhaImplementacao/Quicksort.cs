using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTesteOrdenacao.minhaImplementacao
{
    public class Quicksort
    {
        public void Ordena(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int posicaoPivo = Separar(vetor, inicio, fim);
                Ordena(vetor, inicio, posicaoPivo - 1);
                Ordena(vetor, posicaoPivo + 1, fim);
            }
        }

        private static int Separar(int[] vetor, int inicio, int fim)
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

            return f;
        }

        public void Imprimir(int[] vetor)
        {
            //para imprimir
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine(vetor[k]);
            }
            Thread.Sleep(4000);
        }
    }
}