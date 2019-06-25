using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesteOrdenacao.minhaImplementacao
{
    public interface IOrdenacao2
    {
        void Selecao(int[] vetor);
        void Insercao(int[] vetor);
        void Shellsort(int[] vetor);
        //void Heapsort(Item[] v, int n);
    }
}