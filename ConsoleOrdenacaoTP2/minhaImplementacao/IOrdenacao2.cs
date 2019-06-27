using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrdenacaoTP2.minhaImplementacao
{
    public interface IOrdenacao2
    {
        void BubbleSort(int[] vetor);
        void InsertionSort(int[] vetor); //Insercao
        void SelectionSort(int[] vetor);//Selecao
        void Shellsort(int[] vetor);
    }
}