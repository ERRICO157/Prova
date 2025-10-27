using System;

public class Auto : Veicolo
{
    // Proprietà aggiuntiva specifica dell’auto
    public int NumeroPorte { get; set; }

    // Costruttore della classe derivata
    public Auto(string marca, string modello, int anno, int numeroPorte)
        : base(marca, modello, anno) // chiama il costruttore della classe base
    {
        NumeroPorte = numeroPorte;
    }

    // Sovrascrive il metodo della classe base
    public override void MostraInfo()
    {
        Console.WriteLine($"Auto: {Marca} {Modello}, Anno: {Anno}, Porte: {NumeroPorte}");
    }
}