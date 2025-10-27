using System;

public class Veicolo
{
    // Proprietà della classe base
    public string Marca { get; set; }
    public string Modello { get; set; }
    public int Anno { get; set; }

    // Costruttore
    public Veicolo(string marca, string modello, int anno)
    {
        Marca = marca;
        Modello = modello;
        Anno = anno;
    }

    // Metodo della classe base
    public virtual void MostraInfo()
    {
        Console.WriteLine($"Veicolo: {Marca} {Modello}, Anno: {Anno}");
    }
}