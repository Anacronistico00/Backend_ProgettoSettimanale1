using Backend_ProgettoSettimanale1.Models;

while(true)
{
    Console.Clear();
    Console.WriteLine("==================================================");
    Console.WriteLine("BENVENUTO NEL CALCOLATORE DELL'IMPOSTA DA VERSARE");
    Console.WriteLine("==================================================\n");
    Console.WriteLine("Inserisci i dati del contribuente per calcolare l'imposta da versare:\n");

    Console.Write("Inserisci il nome del Contribuente: ");
    string nome = Console.ReadLine();

    Console.Write("Inserisci il cognome del Contribuente: ");
    string cognome = Console.ReadLine();

    DateTime dataDiNascita;
    while (true)
    {
        Console.Write("Inserisci la tua data di nascita  del Contribuente (gg-mm-yyyy): ");
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

    Console.Write("Inserisci il codice fiscale del Contribuente: ");
    string codiceFiscale = Console.ReadLine();

    Console.Write("Inserisci il comune di residenza del Contribuente: ");
    string comuneResidenza = Console.ReadLine();

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
    if (risposta != "S")
    {
        break;
    }

}
