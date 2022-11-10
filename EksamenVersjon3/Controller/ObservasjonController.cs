using EksamenVersjon3.DAL;
using EksamenVersjon3.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        private ILogger<ObservasjonController> _log; //Initierer IILoggerFactory i controllern

        //Dependency Injection av IObservasjonRepository
        //ILogger blir tatt inn i controllern
        public ObservasjonController(IObservasjonRepository db, ILogger<ObservasjonController> log)
        {
            _db = db;
            _log = log;
        }

        //F�lgende asynkrone CRUD metoder blir initialisert og returnerer metodene i IObservasjonRepository
        public async Task<bool> Lagre(Observasjon innObservasjon)
        {
            _log.LogInformation("En ny observasjon har blitt lagret."); //Logger til fil dersom en ny observasjon har blitt lagret
            return await _db.Lagre(innObservasjon);
        }

        public async Task<List<Observasjon>> HentAlle()
        {
            _log.LogInformation("Alle observasjoner har blitt hentet."); //Logger til fil at alle observasjoner har blitt hentet
            return await _db.HentAlle();
        }

        public async Task<bool> Slett(int id)
        {
            _log.LogInformation("En observasjon har blitt slettet."); //Logger til fil dersom en observasjon har blitt slettet
            return await _db.Slett(id);
        }

        public async Task<Observasjon> HentEn(int id)
        {
            _log.LogInformation("En observasjon har blitt hentet."); //Logger til fil dersom bare en observasjon har blitt hentet
            return await _db.HentEn(id);
        }

        public async Task<bool> Endre(Observasjon endreObservasjon)
        {
            _log.LogInformation("En observasjon har blitt endret."); //Logger til fil dersom en observasjon har blitt endret
            return await _db.Endre(endreObservasjon);
        }

        //Koden under er hentet fra "Controller" mappen som igjen ligger under mappen "KundeApp2-med-hash-logginn" hentet fra canvas
        public async Task<ActionResult> LoggInn(Bruker bruker)
        {
            if (ModelState.IsValid)
            {
                bool returnOK = await _db.LoggInn(bruker);
                if (!returnOK)
                {
                    _log.LogInformation("Innloggingen feilet for bruker" + bruker.Brukernavn);
                    return Ok(false);
                }
                return Ok(true);
            }
            _log.LogInformation("Feil i inputvalidering");
            return BadRequest("Feil i inputvalidering på server");
        }
    }
}