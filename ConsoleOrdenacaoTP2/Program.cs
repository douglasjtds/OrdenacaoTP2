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
        public static int[] vetorDeElementosSemRepeticao;
        public static int tamanhoVetor;
        public static bool comRepeticao;

        static void Main(string[] args)
        {
            //int[] vetorTeste = { 2, 5, 4, 3, 1, 0 };

            Console.Write("Entre com o tamanho do vetor a ser gerado: ");
            tamanhoVetor = Int32.Parse(Console.ReadLine());

            #region [MENU - Escolha o tipo de vetor a ser gerado]
            int tipoDeVetorASerGerado;

            do
            {
                Console.WriteLine("\n");
                //Console.Clear();
                Console.WriteLine("------[Trabalho de AEDs - TP2 - Ordenação]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Vetor aleatório com repetição");
                Console.WriteLine("[ 2 ] Vetor aleatório sem repetição");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha o tipo de vetor que deseja gerar para o cálculo: ");
                tipoDeVetorASerGerado = Int32.Parse(Console.ReadLine());
                switch (tipoDeVetorASerGerado)
                {
                    case 1:
                        comRepeticao = true;
                        GerarVetorAleatorioComRepeticao();
                        ChamarSubmenu();
                        break;
                    case 2:
                        comRepeticao = false;
                        GerarVetorAleatorioSemRepeticao();
                        ChamarSubmenu();
                        break;
                    default:
                        SaiPrograma();
                        break;
                }

            } while (tipoDeVetorASerGerado != 0);
            #endregion

            //#region Gerar vetor aleatório com repetição com repetição
            //#endregion

            //#region Vetor sem repetição
            //#endregion


            Console.WriteLine("\n");
            Console.WriteLine("Pressione enter para continuar.");
            Console.ReadKey();
        }

        private static void ChamarSubmenu()
        {
            #region [SubMENU - Escolha o método de ordenação que deseja utilizar]
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
                        if (comRepeticao)
                            BubbleSort(vetorDeElementosAleatorios);
                        else
                            BubbleSort(vetorDeElementosSemRepeticao);
                        break;

                    case 2:
                        if (comRepeticao)
                            InsertionSort(vetorDeElementosAleatorios);
                        else
                            InsertionSort(vetorDeElementosSemRepeticao);
                        break;

                    case 3:
                        if (comRepeticao)
                            SelectionSort(vetorDeElementosAleatorios);
                        else
                            SelectionSort(vetorDeElementosSemRepeticao);
                        break;

                    case 4:
                        if (comRepeticao)
                            ShellSort(vetorDeElementosAleatorios);
                        else
                            ShellSort(vetorDeElementosSemRepeticao);
                        break;

                    case 5:
                        if (comRepeticao)
                            QuickSort(vetorDeElementosAleatorios);
                        else
                            QuickSort(vetorDeElementosSemRepeticao);

                        break;
                    default:
                        SaiPrograma();
                        break;
                }

            } while (metodoDeOrdenacao != 0);
            #endregion
        }

        private static void GerarVetorAleatorioSemRepeticao()
        {
            vetorDeElementosSemRepeticao = new int[tamanhoVetor];

            var numerosNoVetorSemRepeticao = new Random();

            int numeroQueVaiEntrarNoVetor;

            var contador = 0;
            var numeroMaximo = Convert.ToInt32(tamanhoVetor * 1.8);

            do
            {
                numeroQueVaiEntrarNoVetor = numerosNoVetorSemRepeticao.Next(0, numeroMaximo);

                if (!vetorDeElementosSemRepeticao.Contains(numeroQueVaiEntrarNoVetor))
                {
                    vetorDeElementosSemRepeticao[contador] = numeroQueVaiEntrarNoVetor;
                    contador++;
                }
            } while (contador < tamanhoVetor);

            //for (int i = 0; i < tamanhoVetor; i++)
            //{
            //}

            //para imprimir o vetor desordenado sem repetição
            Console.WriteLine("\nO vetor gerado sem ordenação e sem números repetidos é o seguinte: ");
            for (int k = 0; k < vetorDeElementosSemRepeticao.Length; k++)
            {
                Console.WriteLine("\t" + vetorDeElementosSemRepeticao[k]);
            }
        }

        private static void GerarVetorAleatorioComRepeticao()
        {
            vetorDeElementosAleatorios = new int[tamanhoVetor];

            var numerosNoVetor = new Random();

            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorDeElementosAleatorios[i] = numerosNoVetor.Next(0, tamanhoVetor);
            }

            //para imprimir o vetor desordenado com repetição
            Console.WriteLine("\nO vetor gerado sem ordenação e com números repetidos é o seguinte: ");
            for (int k = 0; k < vetorDeElementosAleatorios.Length; k++)
            {
                Console.WriteLine("\t" + vetorDeElementosAleatorios[k]);
            }
        }

        #region Chamadas dos métodos de ordenação
        private static void BubbleSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.BubbleSort(vetorRecebido);

            Console.Clear();
        }

        private static void InsertionSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.InsertionSort(vetorRecebido);

            Console.Clear();
        }

        private static void SelectionSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.SelectionSort(vetorRecebido);

            Console.Clear();
        }

        private static void ShellSort(int[] vetorRecebido)
        {
            ordenacao = new Ordenacao2();
            ordenacao.Shellsort(vetorRecebido);

            Console.Clear();
        }

        private static void QuickSort(int[] vetorRecebido)
        {
            //ordenacao = new Ordenacao2();
            quicksort = new Quicksort();
            quicksort.Ordena(vetorRecebido, 0, tamanhoVetor - 1);

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