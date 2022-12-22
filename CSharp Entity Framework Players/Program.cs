
using CSharp_Entity_Framework_Players;
using System.Numerics;

using (TeamContext db = new TeamContext()) {
    Random random = new Random();
    double punteggiocorrente = Math.Round((random.NextSingle()*10), 2);
    var partiteVinte = random.Next(1,101);
    var partiteGiocate = random.Next(partiteVinte, 101);
    var NuovoGiocatore = new Player() {Name="Tom",Surname="Pelt",
        Punteggio=punteggiocorrente,PartiteGiocate=partiteGiocate,PartiteVinte=partiteVinte };
    db.Add(NuovoGiocatore);
    db.SaveChanges();
    Console.WriteLine("Giocatore aggiunto");
    Console.WriteLine(NuovoGiocatore);
    NuovoGiocatore.Name = "Michael";
    NuovoGiocatore.Surname = "Bean";
    db.SaveChanges();
    Console.WriteLine("I dati del giocatore sono stati modificati nuovo giocatore:");
    Console.WriteLine(NuovoGiocatore);
    db.Remove(NuovoGiocatore);
    db.SaveChanges();
    Console.WriteLine("Il giocatore è stato eliminato");
}