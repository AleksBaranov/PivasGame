

namespace PivasGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zaprosVConsol = null;
            Teksti.Privetstvie();
            UserProfil.EnterName();
            Teksti.IntroPeredZapuskom();
            zaprosVConsol = Console.ReadLine();
            
            while (zaprosVConsol != "ПНХ")
            {
                if (zaprosVConsol == "HELP")
                {
                    Teksti.HELP();
                    zaprosVConsol= null;
                }
                zaprosVConsol = Console.ReadLine();
                
            }
            





        }
    }
}