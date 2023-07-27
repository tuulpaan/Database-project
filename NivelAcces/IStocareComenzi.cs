using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Librarie_Modele;

namespace NivelAcces
{
    public interface IStocareComenzi : IStocareFactory
    {
        List<Comanda> GetComenzi();
        Comanda GetComenzi(int ID_comanda);
        bool AddComenzi(Comanda comanda);
        bool UpdateComenzi(Comanda comanda);
        bool DeleteComenzi(int ID_comanda);
    }
}
