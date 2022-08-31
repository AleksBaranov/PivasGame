using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PivasGame
{

    public class Teksti
    {
        private static string probeliVerh = "_________________________________________________________";
        public static string probeliNiz = "--------------------------------------------------------";
        

        public static void Privetstvie() 
        {
            Console.WriteLine("Добро пожаловать, в самую мощную и отбитую игру \"ПИВАС\". " +
                "\nВ которой тебе предстоит выпить море пива и постараться не обосать свой стул");
            
        }
        public static void IntroPeredZapuskom()
        {
            Console.WriteLine($"Приветствую {UserProfil.FinishName}.");
            Console.WriteLine("Что, бы получить справку, наберите в строке ПАМАГИ.");
            
            
           
        }
        
        public static void HELP()
        {
            Console.WriteLine("Набрав команду \"Скока там\" - вы узнаете колво заработанных бутылок, кол-во \"Алкашей\" и кол-во \"Ларьков\" .");
            Console.WriteLine("Набрав команду \"ПНХ\" - вы завершите игру.");
            Console.WriteLine("Набрав команду \"ПИВАС\" - вы заработаете 1 бутылку.");
            Console.WriteLine("Набрав определенные команды, вы можете приобрести те или иные опции развития. Таблица опций приведена ниже:");
            Console.WriteLine(probeliVerh);
            Console.WriteLine($"|Команда\t| цена\t| бутылок\t| раз в секунд\t|\n{probeliNiz}");
            Console.WriteLine($"Алкаш\t\t| {NakoplenieButilok.CenaAlaksh}\t| {NakoplenieButilok.DastAlkash}\t\t| {NakoplenieButilok.TimerAlkash}\t\t|\n{probeliNiz}");
            Console.WriteLine($"Ларек\t\t| {NakoplenieButilok.CenaLarek}\t| {NakoplenieButilok.DastLarek}\t\t| {NakoplenieButilok.TimerLarek}\t\t|\n{probeliNiz}");
            Console.WriteLine($"Бар\t\t| {NakoplenieButilok.CenaBar}\t| {NakoplenieButilok.DastBar}\t\t| {NakoplenieButilok.TimerBar}\t\t|\n{probeliNiz}");
            Console.WriteLine($"Пивоварня\t| {NakoplenieButilok.CenaPivovar}\t| {NakoplenieButilok.DastPivovar}\t\t| {NakoplenieButilok.TimerPivovar}\t\t|\n{probeliNiz}");

        }

    }
}
