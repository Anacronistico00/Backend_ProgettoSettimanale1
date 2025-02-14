using Backend_ProgettoSettimanale1.Models;

while (true)
{
    Console.Clear();
    Console.WriteLine("==================================================");
    Console.WriteLine("BENVENUTO NEL CALCOLATORE D'IMPOSTA");
    Console.WriteLine("==================================================\n");
    Console.WriteLine("Inserisci i dati del contribuente per calcolare l'imposta da versare:\n");

    string nome;
    while (true)
    {
        Console.Write("Inserisci il nome del Contribuente: ");
        nome = Console.ReadLine();
        if (!string.IsNullOrEmpty(nome) && nome.All(char.IsLetter))
        {
            break;
        }
        Console.WriteLine("Nome non valido. Devi inserire solo lettere e non può essere vuoto.");
    }
    string cognome;
    while (true)
    {
        Console.Write("Inserisci il cognome del Contribuente: ");
        cognome = Console.ReadLine();
        if (!string.IsNullOrEmpty(cognome) && cognome.All(char.IsLetter))
        {
            break;
        }
        Console.WriteLine("Cognome non valido. Devi inserire solo lettere e non può essere vuoto.");
    }

    DateTime dataDiNascita;
    while (true)
    {
        Console.Write("Inserisci la tua data di nascita  del Contribuente (gg-mm-aaaa o gg/mm/aaaa): ");
        if (DateTime.TryParse(Console.ReadLine(), out dataDiNascita))
        {
            break;
        }
        Console.WriteLine("Data non valida, riprova.");
    }

    char sesso;

    while (true)
    {
        Console.Write("Inserisci il sesso del Contribuente (M/F): ");
        if (char.TryParse(Console.ReadLine().ToUpper(), out sesso) && (sesso == 'M' || sesso == 'F'))
        {
            break;
        }
        Console.WriteLine("Sesso non valido, inserire M o F.");
    }

    string codiceFiscale;
    while (true)
    {
        Console.Write("Inserisci il codice fiscale del Contribuente: ");
        codiceFiscale = Console.ReadLine();
        if (codiceFiscale.Length == 16 && codiceFiscale.All(c => char.IsLetterOrDigit(c)))
        {
            break;
        }
        Console.WriteLine("Codice fiscale non valido. Deve essere lungo 16 caratteri alfanumerici.");
    }

    string comuneResidenza;
    while (true)
    {
        Console.Write("Inserisci il comune di residenza del Contribuente: ");
        comuneResidenza = Console.ReadLine();
        if (!string.IsNullOrEmpty(comuneResidenza) && comuneResidenza.All(c => char.IsLetter(c) || c == '-'))
        {
            break;
        }
        Console.WriteLine("Comune non valido. Puoi inserire solo lettere o città con il trattino, e non può essere vuoto.");
    }

    decimal redditoAnnuale;

    while (true)
    {
        Console.Write("Inserisci il reddito annuale del Contribuente(i centesimi separati da una virgola): ");
        if (decimal.TryParse(Console.ReadLine(), out redditoAnnuale) && redditoAnnuale > 0)
        {
            break;
        }
        Console.WriteLine("Reddito non valido, riprova.");
    }

    Contribuente contribuente = new Contribuente(nome, cognome, dataDiNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

    Console.WriteLine("==================================================");
    Console.WriteLine("\nCALCOLO DELL'IMPOSTA DA VERSARE:\n");
    Console.WriteLine(contribuente);

    Console.WriteLine("\n==================================================");
    Console.Write("\nVuoi calcolare l'imposta per un altro contribuente? (S/N): ");
    string risposta = Console.ReadLine().ToUpper();
    switch (risposta)
    {
        case "S":
            continue;
        case "N":
            Console.WriteLine("Grazie per aver utilizzato il nostro servizio. Arrivederci!");
            return;
        default:
            Console.WriteLine("Scelta non valida, verrai reindirizzato al menu principale.");
            continue;

    }
}
