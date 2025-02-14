using JeuDés;
using JeuDés.Dés;
using JeuDés.Dés.Concrets;

Console.WriteLine("=====================================");
Console.WriteLine("Jeu dés!");
Console.WriteLine("=====================================");

var joueurtest = new Joueur();

var joueurs = new List<Joueur>();
joueurs.Add(new Joueur("Grenier", "Antoine"));
joueurs.Add(new Joueur("Capitaine", "Bonhomme"));

Console.WriteLine("Combien de face?");
var nrbFace = int.Parse(Console.ReadLine());
var fabrique = new FabriqueDés();
var dés = fabrique.Fabrique(5, nrbFace);

int compteur = 0;
while (true)
{
    Console.WriteLine($"Partie # {compteur++}");

    foreach (var joueur in joueurs)
    {
        joueur.Jouer(dés);
    }

    if (joueurs[0].Score == joueurs[1].Score)
    {
        Console.WriteLine("Nulle!");
    }
    else if (joueurs[0].Score == 2)
    {
        Console.WriteLine("Joueur 1 gagne automatiquement");
    }
    else if (joueurs[1].Score == 2)
    {
        Console.WriteLine("Joueur 2 gagne automatiquement");
    }
    else if (joueurs[0].Score > joueurs[1].Score)
    {
        Console.WriteLine("Joueur 1 a un score plus grand");
        Console.WriteLine($"GAGNANT :{joueurs[0].Nom} ; {joueurs[0].Score}");
        Console.WriteLine($"PERDANT :{joueurs[1].Prenom} ; {joueurs[1].Score}");
    }
    else
    {
        Console.WriteLine("Joueur 2 a un score plus grand");
        Console.WriteLine($"GAGNANT :{joueurs[1].Nom} ; {joueurs[1].Score}");
        Console.WriteLine($"PERDANT :{joueurs[0].Prenom} ; {joueurs[0].Score}");
    }
    Console.WriteLine("=====================================");
    Thread.Sleep(2000);
}

//ConcreteSubject iPhone = new ConcreteSubject();
//IObserver antony = new ConcreteObserver("Antony");
//IObserver magalie = new ConcreteObserver("Magalie");

//iPhone.Attach(antony);
//iPhone.Attach(magalie);

//Thread.Sleep(5000);

//iPhone.Notify("Je suis disponible!");

//interface IObserver
//{
//    void Update(string message);
//}

//class ConcreteObserver : IObserver
//{
//    private string name;

//    public ConcreteObserver(string name)
//    {
//        this.name = name;
//    }

//    public void Update(string message)
//    {
//        Console.WriteLine($"{name} received message: {message}");
//    }
//}

//interface ISubject
//{
//    void Attach(IObserver observer);
//    void Detach(IObserver observer);
//    void Notify(string message);
//}

//class ConcreteSubject : ISubject
//{
//    private List<IObserver> observers = new List<IObserver>();

//    public void Attach(IObserver observer)
//    {
//        Console.WriteLine($"Merci de la commande.");
//        observers.Add(observer);
//    }

//    public void Detach(IObserver observer)
//    {
//        observers.Remove(observer);
//    }

//    public void Notify(string message)
//    {
//        foreach (var observer in observers)
//        {
//            observer.Update(message);
//        }
//    }
//}