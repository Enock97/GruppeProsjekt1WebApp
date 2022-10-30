

$(function () { //Denne funksjonen er selvutviklet men noen av delene er hentet fra KundeApp2-med-DAL filen fra canvas
    hentAlleObservasjoner();
});

function hentAlleObservasjoner() { //Denne funksjonen er selvutviklet men noen av delene er hentet fra KundeApp2-med-DAL filen fra canvas
    $.get("observasjon/hentAlle", function (observasjoner) {
        formaterObservasjoner(observasjoner);
    });
}

function formaterObservasjoner(observasjoner) { //Denne funksjonen er selvutviklet men noen av delene er hentet fra KundeApp2-med-DAL filen fra canvas
    let ut = "<section class='alle_innlegg'>";


    for (let observasjon of observasjoner) {
        ut += "<section class='innleggene'>" + " <div class='innlegg_beskrivelse' id='innleggbeskrivelse'>" + observasjon.beskrivelse + "</div >" +
            " <section class='innlegg_hoyredel'>" +
            "<div class='innlegg_navn' id='innleggnavn'>" + observasjon.navn + "</div>" +
            "<div class='innlegg_postkode' id='innleggpostkode'>" + observasjon.postkode + " </div>" +
            "<div class='innlegg_dato' id='innleggdato'>" + observasjon.dato + "</div>" +
            "<div class='innlegg_tid' id='innleggtid'>" + observasjon.tid + "</div>" + "</section>" + "</section>" +

            "<a class='btn btn-primary' href='endre.html?id=" + observasjon.id + "'>Endre</a>" +
            "<button class='btn btn-danger' onclick='slettObv(" + observasjon.id + ")'>Slett</button>";
            
    }
    ut += "</section>";
    $("#observasjoner").html(ut);
}

function slettObv(id) {
    const url = "observasjon/Slett?id=" + id;
    $.get(url, function (OK) {
        if (OK) {
            location.reload();
        }
        else {
            $("#feil").html("Error: Klarte ikke slette observasjon");
        }

    });
};