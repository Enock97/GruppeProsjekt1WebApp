using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EksamenVersjon3.Model
{
    //Denne klassen er hentet fra KundeApp2-med-DB filen i KundeApp2-med-DAL mappen fra canvas
    public class Observasjon //Vanlig POJO klasse for observasjonene
    {
        public int Id { get; set; }  // Id blir brukt som auto-increment i databasen
        public string Navn { get; set; }
        public string Postkode { get; set; }
        public string Beskrivelse { get; set; }
        public string Dato { get; set; }
        public string Tid { get; set; }
    }
}