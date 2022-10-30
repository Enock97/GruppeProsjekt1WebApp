function lagreObv() { //Denne funksjonen er selvutviklet men noen av delene er hentet fra KundeApp2-med-DAL filen fra canvas
    const observasjon = {
        Navn: $("#Navn").val(),
        Postkode: $("#Postkode").val(),
        Beskrivelse: $("#Obv").val(),
        Dato: $("#Dato").val(),
        Tid: $("#Tid").val()
    }
  
    const url = "observasjon/Lagre";
    $.post(url, observasjon, function (OK) {
        if (OK) {
            window.location.href = 'index.html';
        }
        else {
            $("#feil").html("Feil i db - prøv igjen senere");
        }
    });
};
