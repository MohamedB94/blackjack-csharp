namespace blackjack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans mon projet C# : BlackJack");
            Jeu jeu = new Jeu();
            jeu.Jouer();
        }
    }
}