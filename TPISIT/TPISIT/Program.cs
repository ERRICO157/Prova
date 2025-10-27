class Program
{
    static void Main(string[] args)
    {
        Veicolo veicolo = new Veicolo("Fiat", "Panda", 2015);
        veicolo.MostraInfo();

        Auto auto = new Auto("Tesla", "Model 3", 2023, 4);
        auto.MostraInfo();
    }
}