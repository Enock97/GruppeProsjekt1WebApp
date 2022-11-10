﻿//Denne koden er hentet fra "wwwroot/js" mappen som igjen ligger under mappen "KundeApp2-med-hash-logginn" hentet fra canvas

function loggInn() {

    const brukernavnOK = validerBrukernavn($("#brukernavn").val());
    const passordOK = validerPassord($("#passord").val());

    if (brukernavnOK && passordOK) {
        const bruker = {
            brukernavn: $("#brukernavn").val(),
            passord: $("#passord").val()
        }
        $.post("Kunde/LoggInn", bruker, function (OK) {
            if (OK) {
                window.location.href = 'index.html';
            }
            else {
                $("#feil").html("Feil brukernavn eller passord");
            }
        })
            .fail(function () {
                $("#feil").html("Feil på server - prøv igjen senere");
            });
    }
}
