using EksamenVersjon3.DAL;
using EksamenVersjon3.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EksamenVersjon3.Controllers
{
    //Denne klassen er hentet fra KundeApp2-med-DB filen i KundeApp2-med-DAL mappen fra canvas
    [Route("[controller]/[action]")]
    public class ObservasjonController : ControllerBase
    {
        private readonly IObservasjonRepository _db; //Initierer IObservasjoRepository db variabel

        public ObservasjonController(IObservasjonRepository db) //Dependency Injection av IObservasjonRepository
        {
            _db = db;
        }

        //Følgende asynkrone CRUD metoder blir initialisert og returnerer metodene i IObservasjonRepository
        public async Task<bool> Lagre(Observasjon innObservasjon)
        {
            return await _db.Lagre(innObservasjon);
        }

        public async Task<List<Observasjon>> HentAlle()
        {
            return await _db.HentAlle();
        }

        public async Task<bool> Slett(int id)
        {
            return await _db.Slett(id);
        }

        public async Task<Observasjon> HentEn(int id)
        {
            return await _db.HentEn(id);
        }

        public async Task<bool> Endre(Observasjon endreObservasjon)
        {
            return await _db.Endre(endreObservasjon);
        }
    }
}