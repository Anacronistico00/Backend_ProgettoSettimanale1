namespace Backend_ProgettoSettimanale1.Models
{
    public class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public char Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public decimal RedditoAnnuale { get; set; }

        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        public decimal CalcoloImposta()
        { 
            decimal imposta = 0;

            switch (RedditoAnnuale)
            {
                case <= 15000:
                    imposta = RedditoAnnuale * 0.23m;
                    break;
                case <= 28000:
                    imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
                    break;
                case <= 55000:
                    imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
                    break;
                case <= 75000:
                    imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
                    break;
                default:
                    imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;
                    break;
            }

            return imposta;
        }
        public override string ToString()
        {
            return $"Contribuente: {Nome} {Cognome},\n" +
                   $"nato il {DataNascita:dd/MM/yyyy} ({Sesso}),\n" +
                   $"residente a {ComuneResidenza},\n" +
                   $"codice fiscale: {CodiceFiscale}\n\n" +
                   $"Reddito dichiarato: {RedditoAnnuale.ToString("N2")}\n" +
                   $"IMPOSTA DA VERSARE: Eur {CalcoloImposta().ToString("N2")}";
        }
    }
}
