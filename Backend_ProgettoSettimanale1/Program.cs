using Backend_ProgettoSettimanale1.Models;

Console.Write("Inserisci il tuo nome: ");
string nome = Console.ReadLine();

Console.Write("Inserisci il tuo cognome: ");
string cognome = Console.ReadLine();

DateTime dataDiNascita;
while (true)
{
    Console.Write("Inserisci la tua data di nascita (gg-mm-yyyy): ");
    if (DateTime.TryParse(Console.ReadLine(), out dataDiNascita))
    {
        break;
    }
    Console.WriteLine("Data non valida, riprova.");
}

char sesso;

while (true)
{
    Console.Write("Inserisci il tuo sesso (M/F): ");
    if (char.TryParse(Console.ReadLine(), out sesso) && (sesso == 'M' || sesso == 'F'))
    {
        break;
    }
    Console.WriteLine("Sesso non valido, inserire M o F.");
}

Console.Write("Inserisci il tuo codice fiscale: ");
string codiceFiscale = Console.ReadLine();

Console.Write("Inserisci il tuo comune di residenza: ");
string comuneResidenza = Console.ReadLine();

decimal redditoAnnuale;

while (true)
{
    Console.Write("Inserisci il reddito annuale: ");
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