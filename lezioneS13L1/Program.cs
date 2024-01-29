namespace lezioneS13L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atleta
            Atleta atleta1 = new Atleta("Alessandro Nesta", 25, "Calcio");
            Atleta atleta2 = new Atleta("Roger Federer", 30, "Tennis");
            Atleta atleta3 = new Atleta("Federica Pellegrini", 28, "Nuoto");

            // Dipendente
            Dipendente dipendente1 = new Dipendente("Flavio Russo", "Sviluppatore", 3000);
            Dipendente dipendente2 = new Dipendente("Roberto Serra", "Contabile", 2000);

            // Animale
            Animale animale1 = new Animale("Semola", "Cane", 4);
            Animale animale2 = new Animale("Leo", "Gatto", 3);
            Animale animale3 = new Animale("Cocorito", "Pappagallo", 3);

            // Veicolo
            Veicolo veicolo1 = new Veicolo("Auto", "Toyota", 2020);
            Veicolo veicolo2 = new Veicolo("Moto", "Honda", 2019);
            Veicolo veicolo3 = new Veicolo("Camion", "Iveco", 2022);

            // Stampa
            Console.WriteLine("Informazioni sugli Atleti:");
            Console.WriteLine(atleta1.GetInfo());
            Console.WriteLine(atleta2.GetInfo());
            Console.WriteLine(atleta3.GetInfo());

            Console.WriteLine("\nInformazioni sui Dipendenti:");
            Console.WriteLine(dipendente1.GetInfo());
            Console.WriteLine(dipendente2.GetInfo());

            Console.WriteLine("\nInformazioni sugli Animali:");
            Console.WriteLine(animale1.GetInfo());
            Console.WriteLine($"Suono: {animale1.EmettiSuono()}");
            Console.WriteLine(animale2.GetInfo());
            Console.WriteLine($"Suono: {animale2.EmettiSuono()}");
            Console.WriteLine(animale3.GetInfo());
            Console.WriteLine($"Suono: {animale3.EmettiSuono()}");

            Console.WriteLine("\nInformazioni sui Veicoli:");
            Console.WriteLine(veicolo1.GetInfo());
            Console.WriteLine(veicolo2.GetInfo());
            Console.WriteLine(veicolo3.GetInfo());

        }
    }
    class Atleta
    {
        public string Nome { get; set; }
        public int Età { get; set; }
        public string Sport { get; set; }

        public Atleta(string nome, int età, string sport)
        {
            Nome = nome;
            Età = età;
            Sport = sport;
        }

        public string GetInfo()
        {
            return $"Atleta: {Nome}, Età: {Età}, Sport: {Sport}";
        }
    }

    class Dipendente
    {
        public string Nome { get; set; }
        public string Ruolo { get; set; }
        public decimal Stipendio { get; set; }

        public Dipendente(string nome, string ruolo, decimal stipendio)
        {
            Nome = nome;
            Ruolo = ruolo;
            Stipendio = stipendio;
        }

        public string GetInfo()
        {
            return $"Dipendente: {Nome}, Ruolo: {Ruolo}, Stipendio: {Stipendio}";
        }
    }

    class Animale
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Età { get; set; }

        public Animale(string nome, string tipo, int età)
        {
            Nome = nome;
            Tipo = tipo;
            Età = età;
        }

        public string GetInfo()
        {
            return $"Animale: {Nome}, Tipo: {Tipo}, Età: {Età} anni";
        }

        public string EmettiSuono()
        {
            switch (Tipo.ToLower())
            {
                case "cane":
                    return "Woof!";
                case "gatto":
                    return "Meow!";
                case "pappagallo":
                    return "Craah!";
                default:
                    return "Sconosciuto";
            }
        }

    }

    class Veicolo
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public int Anno { get; set; }

        public Veicolo(string tipo, string marca, int anno)
        {
            Tipo = tipo;
            Marca = marca;
            Anno = anno;
        }

        public string GetInfo()
        {
            int eta = CalcolaEta();
            return $"Veicolo: {Tipo}, Marca: {Marca}, Anno: {Anno}, Età: {eta} anni";
        }

        private int CalcolaEta()
        {
            int annoCorrente = DateTime.Now.Year;
            int eta = annoCorrente - Anno;
            return eta;
        }
    }

}

