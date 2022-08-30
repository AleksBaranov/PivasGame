using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PivasGame
{

    public class Teksti
    {
        

        public static void Privetstvie() 
        {
            Console.WriteLine("Добро пожаловать, в самую мощную и отбитую игру \"ПИВАС\". " +
                "\nВ которой тебе предстоит выпить море пива и постараться не обосать свой стул");
            
        }
        public static void IntroPeredZapuskom()
        {
            Console.Write("Если вы готовы, введите свое имя: ");
            Console.WriteLine($"Приветствую {UserProfil.FinishName}.");
            Console.WriteLine("Что, бы получить справку, наберите в строке HELP.");
            
            
           
        }
        
        public static void HELP()
        {
            Console.WriteLine("Набрав команду \"Скока там\" - вы узнаете колво заработанных бутылок, кол-во \"Алкашей\" и кол-во \"Ларьков\" .");
            Console.WriteLine("Набрав команду \"ПНХ\" - вы завершите игру.");
            Console.WriteLine("Набрав команду \"ПИВАС\" - вы заработаете 1 бутылку.");
            Console.WriteLine("Набрав команды \"Купить Алкаша\" или \"Купить Ларек\" - вы купиеь соответствующую позицию, если будете обладать необходимым кол-вом бутылок.");
            Console.WriteLine("Стоимость Алкаша - 10 бутылки. Стоимость Ларька - 50 тубылок.");
        }
        
        

       
       
        
    }
}
