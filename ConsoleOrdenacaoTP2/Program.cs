using ConsoleOrdenacaoTP2.minhaImplementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdenacaoTP2
{
    public class Program
    {
        private static Ordenacao2 ordenacao;
        private static Quicksort quicksort;

        public static int[] vetorDeElementosAleatorios;
        public static int tamanhoVetor;

        static void Main(string[] args)
        {
            //int[] vetorTeste = { 2, 5, 4, 3, 1, 0 };

            Console.Write("Entre com o tamanho do vetor a ser gerado: ");
            tamanhoVetor = Int32.Parse(Console.ReadLine());

            vetorDeElementosAleatorios = new int[tamanhoVetor];

            var numerosNoVetor = new Random();

            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorDeElementosAleatorios[i] = numerosNoVetor.Next(0, tamanhoVetor);
            }

            //para imprimir o vetor desordenado
            Console.WriteLine("\nO vetor gerado sem ordenação é o seguinte: ");
            for (int k = 0; k < vetorDeElementosAleatorios.Length; k++)
            {
                Console.WriteLine("\t" + vetorDeElementosAleatorios[k]);
            }
            //Thread.Sleep(4000);

            Console.WriteLine("\n");
            Console.WriteLine("Pressione enter para continuar.");
            Console.ReadKey();

            #region [MENU - Escolha o método de ordenação que deseja utilizar]
            int metodoDeOrdenacao;

            do
            {
                Console.WriteLine("\n");
                //Console.Clear();
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
                        BubbleSort(vetorDeElementosAleatorios);
                        break;
                    case 2:
                        InsertionSort(vetorDeElementosAleatorios);
                        break;
                    case 3:
                        SelectionSort(vetorDeElementosAleatorios);
                        break;
                    case 4:
                        ShellSort(vetorDeElementosAleatorios);
                        break;
                    case 5:
                        QuickSort(vetorDeElementosAleatorios);
                        break;
                    default:
                        SaiPrograma();
                        break;
                }

            } while (metodoDeOrdenacao != 0);
            #endregion
        }

        #region Chamadas dos métodos de ordenação
        private static void BubbleSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.BubbleSort(vetorDeElementosAleatorios);

            Console.Clear();
        }

        private static void InsertionSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.InsertionSort(vetorDeElementosAleatorios);

            Console.Clear();
        }

        private static void SelectionSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.SelectionSort(vetorDeElementosAleatorios);

            Console.Clear();
        }

        private static void ShellSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.Shellsort(vetorDeElementosAleatorios);

            Console.Clear();
        }

        private static void QuickSort(int[] vetorRecebido)
        {
            //ordenacao = new Ordenacao2();
            quicksort = new Quicksort();
            quicksort.Ordena(vetorDeElementosAleatorios, 0, tamanhoVetor - 1);

            Console.Clear();
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