using ConsoleTesteOrdenacao.minhaImplementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoTP2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //int[] vetorTeste = { 2, 5, 4, 3, 1, 0 };

            int tamanhoVetor = 0;

            Console.Write("Entre com o tamanho do vetor: ");
            tamanhoVetor = Int32.Parse(Console.ReadLine());

            int[] vetorTeste = new int[tamanhoVetor];

            var numerosNoVetor = new Random();

            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorTeste[i] = numerosNoVetor.Next(0, tamanhoVetor);
            }

            Ordenacao2 ordenacao = new Ordenacao2();

            ordenacao.Insercao(vetorTeste);

        }
    }
}