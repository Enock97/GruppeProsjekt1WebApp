const numbers = [1888, 2000, 2344, 5788, 6745, 9887];
const postnummer1 = 2000;
const postnummer2 = 4000;
const postnummer3 = 6000;
const postnummer4 = 8000;
const postnummer5 = 10000;


const resultat1 = numbers.filter(number => number < postnummer1).length;
const resultat2 = numbers.filter(number => number >= postnummer1 && number < postnummer2).length;
const resultat3 = numbers.filter(number => number >= postnummer2 && number < postnummer3).length;
const resultat4 = numbers.filter(number => number >= postnummer3 && number < postnummer4).length;
const resultat5 = numbers.filter(number => number >= postnummer4 && number < postnummer5).length;


console.log("Antall observasjoner i region en: " + resultat1);
console.log("Antall observasjoner i region to: " + resultat2);
console.log("Antall observasjoner i region tre: " + resultat3);
console.log("Antall observasjoner i region fire: " + resultat4);
console.log("Antall observasjoner i region fem: " + resultat5);

//Kode inspirert av linken under:
//https://dirask.com/snippets/javascript/js%20count%20numbers%20less%20than%20x%20in%20array
//Vi tenker å videreutvikle dette i oppgave 2. Dette dokumenteres.

