using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Librarie_Modele;

namespace NivelAcces
{
    public interface IStocareDulciuri : IStocareFactory
    {
        List<Dulciuri> GetDulciuri();
        Dulciuri GetDulciuri(int ID_dulce);
        bool AddDulciuri(Dulciuri dulciu);
        bool UpdateDulciuri(Dulciuri dulciu);
        bool DeleteDulciuri(int ID_dulce);
    }
}
