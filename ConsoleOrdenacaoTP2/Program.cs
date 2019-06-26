using ConsoleOrdenacaoTP2.minhaImplementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoTP2
{
    public class Program
    {
        private static Ordenacao2 ordenacao;
        //private static Quicksort quicksort;

        public int[] vetorTeste;

        static void Main(string[] args)
        {
            //int[] vetorTeste = { 2, 5, 4, 3, 1, 0 };

            Console.Write("Entre com o tamanho do vetor a ser gerado: ");
            int tamanhoVetor = Int32.Parse(Console.ReadLine());

             int[] vetorTeste = new int[tamanhoVetor]; //vetor teste precisa ser variável global, mas não tá permitindo, pq?

            #region [Escolha o método de ordenação que deseja utilizar]
            int metodoDeOrdenacao;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Trabalho de AEDs - TP2 - Ordenação]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] BubbleSort");
                Console.WriteLine("[ 2 ] InsertionSort");
                Console.WriteLine("[ 3 ] SelectionSort");
                Console.WriteLine("[ 4 ] ShellSort");
                Console.WriteLine("[ 5 ] QuickSort");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha o método de ordenação que deseja utilizar: ");
                metodoDeOrdenacao = Int32.Parse(Console.ReadLine());
                switch (metodoDeOrdenacao)
                {
                    case 1:
                        BubbleSort();
                        break;
                    case 2:
                        InsertionSort();
                        break;
                    case 3:
                        SelectionSort();
                        break;
                    case 4:
                        ShellSort();
                        break;
                    case 5:
                        QuickSort();
                        break;
                    default:
                        SaiPrograma();
                        break;
                }

            } while (metodoDeOrdenacao != 0);
            #endregion

            var numerosNoVetor = new Random();

            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorTeste[i] = numerosNoVetor.Next(0, tamanhoVetor);
            }

            ordenacao = new Ordenacao2();

            ordenacao.InsertionSort(vetorTeste);

        }


        #region Chamadas dos métodos de ordenação
        private static void BubbleSort()
        {
            throw new NotImplementedException();
        }

        private static void InsertionSort()
        {
            throw new NotImplementedException();
            //ordenacao = new Ordenacao2();

            //ordenacao.InsertionSort(vetorTeste);
        }

        private static void SelectionSort()
        {
            throw new NotImplementedException();
        }

        private static void ShellSort()
        {
            throw new NotImplementedException();
        }

        private static void QuickSort()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region para fechar o programa
        private static void SaiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do programa. Clique qualquer tecla para fechar...");
        }
        #endregion
    }
}