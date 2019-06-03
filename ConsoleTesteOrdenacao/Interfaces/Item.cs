using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoTP2.Interfaces
{
    public interface Item
    {
        int Compara(Item it);
        void AlteraChave(Object chave);
        Object RecuperaChave();
    }
}