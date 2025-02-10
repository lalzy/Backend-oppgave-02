
public class DagensMelding{
    /// <summary>
    /// Key - Dagen
    /// Value - meldingen for den dagen.
    /// </summary>
    private static Dictionary<string, string> meldingStrings = new Dictionary<string, string>(){
        {"mandag", "God start på car, bare cdr igjen!"},
        {"tirsdag", "godt i gang i cadr!"},
        {"onsdag", "tenk at du er på caddr allerede!"},
        {"torsdag", "Vi kan fortsat representere dagen som cadddr!"},
        {"fredag", "caddddr is undefined... Men da var det helg!"},
        {"lørdag", "snart må du conse!"},
        {"søndag", "siste dag av uka, på tide å `(cons ,@weekdays)"}
    };

/// <summary>
/// Henter dagen fra DateTime, og passer på å returnere norsk-navn for den.
/// </summary>
/// <param name="dag">DateTime</param>
/// <returns>String: Navnet på dagen (ex: mandag)</returns>
    static string? fåDag (DateTime dag){
        switch((int)dag.DayOfWeek){
            case 0:
                return "søndag";
            case 1:
                return "mandag";
            case 2:
                return "tirsdag";
            case 3:
                return "onsdag";
            case 4:
                return "torsdag";
            case 5:
                return "fredag";
            case 6:
                return "lørdag";
        }
        return null;
    }
    /// <summary>
    /// Enkel test som går over alle 7 dagene i uka for å se alle meldingene.
    /// </summary>
    static public void dagsMeldingTest(){
        // Garanterer at test starter på mandag.
        DateTime dag = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        // kjører over hver dag i uka og sjekker at vi får riktig melding.
        for(int i = 0; i < 8; i++){ // avslutter på mandag igjen, for å garantere at det sirkler.
            Console.Write($"dag: {fåDag(dag.AddDays(i))}, melding: ");
            dagsMelding(dag);
        }
    }

    /// <summary>
    /// method for å sjekke dagens melding.
    /// </summary>
    static public void DagsMelding (){
        dagsMelding(DateTime.Now);
    }


    /// <summary>
    /// Method for å sjekke melding av angit dag
    /// </summary>
    /// <param name="dagen">DateTime</param>
    static void dagsMelding(DateTime dagen){
        string? dag = fåDag(dagen);
        if (dag != null){
            Console.WriteLine($"{meldingStrings[dag.ToLower()]}");
        }
    }

}
