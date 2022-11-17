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
    })
        //Denne koden er hentet fra "wwwroot/js/index.js" mappen som igjen ligger under mappen "KundeApp2-med-logginn-sessions" hentet fra canvas
    .fail(function (feil) {
        if (feil.status == 401) {  // ikke logget inn, redirect til loggInn.html
            window.location.href = 'loggInn.html';
        }
        else {
            $("#feil").html("Feil på server - prøv igjen senere");
        }
    });


};
