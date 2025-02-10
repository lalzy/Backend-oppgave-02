﻿/*
Her skal dere designe et program som skal returnere en bedskjed tilbake til en bruker basert på noen valgfrie parametere.
Dere kan selv bestemme hvilke parametere som skal bestemme hva hilsen kommer tilbake, men her kommer noen tips:
*/


/*Psudo Code:

Funskjon - melding (dagen å sjekke):
    Dagen i dag = DateTime -> dag i dag.

    Mandag - God start på car, bare cdr igjen!
    tirsdag - godt i gang i cadr!
    onsdag - tenk at du er på caddr allerede!
    torsdag - Vi kan fortsat representere dagen som cadddr!
    fredag - caddddr is undefined... Men da var det helg!
    lørdag - snart må du conse
    søndag - siste dag av uka, på tide å `(cons ,@weekdays)
*/


void dagsMelding (){
    var idag = DateTime.Now;
    Console.WriteLine(idag);
}
dagsMelding();