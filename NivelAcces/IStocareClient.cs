using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Librarie_Modele;

namespace NivelAcces
{
    public interface IStocareClienti : IStocareFactory
    {
        List<Client> GetClienti();
        Client GetClient(int ID_client);
        bool AddClient(Client client);
        bool UpdateClient(Client client);
        bool DeleteClient(int ID_client);
    }
}
