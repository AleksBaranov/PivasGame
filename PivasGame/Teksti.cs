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
            Console.WriteLine($"Приветствую {UserProfil.FinishName}.\n");
            //Console.WriteLine("Что, бы получить справку, наберите в строке ПАМАГИ.");
            
            
           
        }
        
        public static void HELP()
        {
            string probeliVerh = new string('_', 57);
            string probeliNiz = new string('-', 57);
            string probeltext = new string(' ', 57);
            Console.WriteLine("Набрав команду \"ПНХ\" - вы завершите игру.");
            Console.WriteLine("Набрав команду \"ПИВАС\" - вы заработаете 1 бутылку.");
            Console.WriteLine("Набрав определенные команды, вы можете приобрести те или иные опции развития. Таблица опций приведена ниже:");
            Console.WriteLine();
            Console.WriteLine($"{probeliVerh}\t\t---------У Вас-----------+");
            Console.WriteLine($"|Команда\t| цена\t| бутылок\t| раз в секунд\t|\t       /                         |");
            Console.WriteLine($"{probeliNiz}\t +----                           |");
            Console.WriteLine($"Алкаш\t\t| {NakoplenieButilok.CenaAlaksh}\t| {NakoplenieButilok.DastAlkash}\t\t| {NakoplenieButilok.TimerAlkash}\t\t|\t |     {NakoplenieButilok.ObshayaSummaButilok}");
            Console.WriteLine($"Ларек\t\t| {NakoplenieButilok.CenaLarek}\t| {NakoplenieButilok.DastLarek}\t\t| {NakoplenieButilok.TimerLarek}\t\t|\t +----                           |");
            Console.WriteLine($"Бар\t\t| {NakoplenieButilok.CenaBar}\t| {NakoplenieButilok.DastBar}\t\t| {NakoplenieButilok.TimerBar}\t\t| \t       \\                         |");
            Console.WriteLine($"Пивоварня\t| {NakoplenieButilok.CenaPivovar}\t| {NakoplenieButilok.DastPivovar}\t\t| {NakoplenieButilok.TimerPivovar}\t\t| \t\t---------Бутылок---------+");
            Console.WriteLine($"{probeliNiz}");


        }

    }
}
