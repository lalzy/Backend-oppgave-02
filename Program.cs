﻿
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

using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Test:");
DagensMelding.dagsMeldingTest(); // kjører test funksjonen som viser alle meldingene.

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Dagens Melding:");
DagensMelding.DagsMelding();
Console.WriteLine("--------------------------------------------------");