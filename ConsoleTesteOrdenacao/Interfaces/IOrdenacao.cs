using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoTP2.Interfaces
{
    public interface IOrdenacao
    {
        void Selecao(Item[] v, int n);
        void Insercao(Item[] v, int n);
        void Shellsort(Item[] v, int n);
        void Quicksort(Item[] v, int n);
        void Heapsort(Item[] v, int n);
    }
}