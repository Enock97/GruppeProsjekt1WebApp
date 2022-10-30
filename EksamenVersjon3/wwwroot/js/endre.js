$(function () { //Denne funksjonen er selvutviklet men noen av delene er hentet fra KundeApp2-med-DAL filen fra canvas
 
    const id = window.location.search.substring(1);
    const url = "observasjon/HentEn?" + id;
    $.get(url, function (observasjon) {
        $("#Id").val(observasjon.id); 
        $("#Navn").val(observasjon.navn);
        $("#Postkode").val(observasjon.postkode);
        $("#Obv").val(observasjon.beskrivelse);
        $("#Dato").val(observasjon.dato);
        $("#Tid").val(observasjon.tid);
    });
});


function endreObv() { //Denne funksjonen er selvutviklet men noen av delene er hentet fra KundeApp2-med-DAL filen fra canvas
    const obvservasjon = {
        id: $("#Id").val(), 
        Navn: $("#Navn").val(),
        Postkode: $("#Postkode").val(),
        Beskrivelse: $("#Obv").val(),
        Dato: $("#Dato").val(),
        Tid: $("#Tid").val()
    }
    $.post("observasjon/Endre", obvservasjon, function (OK) {
        if (OK) {
            window.location.href = 'index.html';
        }
        else {
            $("#feil").html("Error: Klarte ikke endre Observasjon");
        }
    });
}
