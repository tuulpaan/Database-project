using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarie_Modele;
using NivelAcces;
using System.Configuration;

namespace Librarie_Modele
{
    internal class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        //only one break
                        if (tipEntitate == typeof(Dulciuri))
                        {
                            return new AdministrareDulciuri();
                        }
                        if (tipEntitate == typeof(Client))
                        {
                            return new AdministrareClienti();
                        }
                        if (tipEntitate == typeof(Comanda))
                        {
                            return new AdministrareComenzi();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
