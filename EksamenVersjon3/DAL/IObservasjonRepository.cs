using EksamenVersjon3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EksamenVersjon3.DAL
{
    //Dette interfacet er hentet fra KundeApp2-med-DB filen i KundeApp2-med-DAL mappen fra canvas
    public interface IObservasjonRepository //Interface som implementerer metodene i ObservasjonRepository
    {
        Task<bool> Lagre(Observasjon innObservasjon);
        Task<List<Observasjon>> HentAlle();
        Task<bool> Slett(int id);
        Task<Observasjon> HentEn(int id);
        Task<bool> Endre(Observasjon endreObservasjon);
    }
}