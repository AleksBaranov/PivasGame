using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivasGame
{
    internal class NakoplenieButilok
    {
        #region //Блок инициализации переменных
        private static string zaprosVConsol;

        private static long obshayaSummaButilok = 0;

        private static int exit = 1;
        //переменные на каждую опцию. по хорошему надо было реализовать классами, но уже как есть
        private static int kolvoAlkash = 0;
        private static int dastAlkash = 2;
        private static int timerAlkash = 5;
        private static int tempSumAlkash = 0;
        private static int cenaAlkasha = 10;

        private static int kolvoLarek = 0;
        private static int dastlarek = 5;
        private static int timerLarek = 10;
        private static int tempSumLarek = 0;
        private static int cenaLarek = 50;

        private static int kolvoBar = 0;
        private static int dastBar = 20;
        private static int timerBar = 30;
        private static int tempSumBar = 0;
        private static int cenaBar = 500;

        private static int kolvoPivovar = 0;
        private static int dastPivovar = 40;
        private static int timerPivovar = 60;
        private static int tempSumPivovar = 0;
        private static int cenaPivovar = 3000;
        #endregion

        public static void Funkcional()
        {
            //запускает потоки накопления бутылок алкашами, ларьками, барами, пивоварнями
            Thread thAlkash = new Thread(nesetAlkash);
            thAlkash.Start();
            Thread thLarek = new Thread(nesetLarek);
            thLarek.Start();
            Thread thBar = new Thread(nesetBar);
            thBar.Start();
            Thread thPivovar = new Thread(nesetPivovar);
            thPivovar.Start();

            //Предстартовое окно
            Teksti.HELP();
            Console.Write("Я жду Вашей команды милорд: ");
            zaprosVConsol = Console.ReadLine();
            zaprosVConsol = zaprosVConsol.ToUpper();

            #region //основной цикл. выйдя из цикла, игра будет завершена.
            while (zaprosVConsol != "ПНХ")
            {

                if (zaprosVConsol == "ПИВАС")
                {
                    pereraschet();
                    obshayaSummaButilok++;
                    Console.Clear();

                    kolvoRabov();

                }

                if (zaprosVConsol == "АЛКАШ")
                {
                    pereraschet();
                    if (obshayaSummaButilok < 10)
                    {
                        Console.Clear();
                        kolvoRabov();
                        Console.WriteLine();
                        Console.WriteLine("!!! У вас не достаточно бутылок. Стоимость Алкаша 10 бутылок.!!!");
                        Console.WriteLine();

                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 10;
                        kolvoAlkash++;
                        Console.Clear();
                        kolvoRabov();
                    }
                }

                if (zaprosVConsol == "ЛАРЕК")
                {
                    pereraschet();
                    if (obshayaSummaButilok < 50)
                    {
                        Console.Clear();
                        kolvoRabov();
                        Console.WriteLine();
                        System.Console.WriteLine("!!! У вас не достаточно бутылок. Стоимость Ларька 50 бутылок.!!!");
                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 50;
                        kolvoLarek++;
                        Console.Clear();
                        kolvoRabov();
                    }
                }

                if (zaprosVConsol == "БАР")
                {
                    pereraschet();
                    if (obshayaSummaButilok < 500)
                    {
                        Console.Clear();
                        kolvoRabov();
                        Console.WriteLine();
                        Console.WriteLine("!!! У вас не достаточно бутылок. Стоимость Бара 500 бутылок.!!!");
                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 500;
                        kolvoBar++;
                        Console.Clear();
                        kolvoRabov();
                    }
                }

                if (zaprosVConsol == "ПИВОВАРНЯ")
                {
                    pereraschet();
                    if (obshayaSummaButilok < 500)
                    {
                        Console.Clear();
                        kolvoRabov();
                        Console.WriteLine();
                        System.Console.WriteLine("!!! У вас не достаточно бутылок. Стоимость Пивоварни 3000 бутылок.!!!");
                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 3000;
                        kolvoPivovar++;
                        Console.Clear();
                        kolvoRabov();
                    }
                }
                Console.WriteLine();
                Console.Write("Я жду Вашей команды милорд: ");
                zaprosVConsol = Console.ReadLine();
                zaprosVConsol = zaprosVConsol.ToUpper();
            }
            #endregion

            exit = 3; //для завершения циклов потоков

            //Финальный текст, после выполнения команды "ПНХ"
            Console.WriteLine($"{UserProfil.FinishName} игра окончена. Вы набрали: {obshayaSummaButilok} бутылок, \nНаняли {kolvoAlkash} Алкашей и построили {kolvoLarek} ларьков, {kolvoBar} баров, {kolvoPivovar} пивоварню"); ;
            Console.ReadLine();
        }
        #region //Группа потоков производящих накопление бутылок опциями алкаш, ларек, бар, пивоварня
        static void nesetAlkash()
        {
            for (exit = exit; exit < 2; exit = exit)
            {
                tempSumAlkash = tempSumAlkash + (kolvoAlkash * dastAlkash);
                Thread.Sleep(timerAlkash * 1000);
            }
        }


        static void nesetLarek()
        {
            for (exit = exit; exit < 2; exit = exit)
            {
                tempSumLarek = tempSumLarek + (kolvoLarek * dastlarek);
                Thread.Sleep(timerLarek * 1000);
            }
        }

        static void nesetBar()
        {
            for (exit = exit; exit < 2; exit = exit)
            {
                tempSumBar = tempSumBar + (kolvoBar * dastBar);
                Thread.Sleep(timerBar * 1000);
            }
        }

        static void nesetPivovar()
        {
            for (exit = exit; exit < 2; exit = exit)
            {
                tempSumPivovar = tempSumPivovar + (kolvoPivovar * dastPivovar);
                Thread.Sleep(timerPivovar * 1000);
            }
        }
        #endregion

        #region // Группа гетеров для переменных таймеров алкашей, ларьков, баров, пивоварен
        public static int TimerAlkash
        {
            get { return timerAlkash; }
        }
        public static int TimerLarek
        {
            get { return timerLarek; }
        }
        public static int TimerBar
        {
            get { return timerBar; }
        }
        public static int TimerPivovar
        {
            get { return timerPivovar; }
        }
        #endregion

        #region // Группа гетеров для переменных колво бутылок которые приносит за тик алкаш, ларек, бар, пивоварня
        public static int DastAlkash
        {
            get { return dastAlkash; }
        }
        public static int DastLarek
        {
            get { return dastlarek; }
        }
        public static int DastBar
        {
            get { return dastBar; }
        }
        public static int DastPivovar
        {
            get { return dastPivovar; }
        }
        #endregion

        #region //Група гетеров цена за 1 опцию алкаш, ларек, бар, пивоварня
        public static int CenaAlaksh
        {
            get { return cenaAlkasha; }
        }
        public static int CenaLarek
        {
            get { return cenaLarek; }
        }
        public static int CenaBar
        {
            get { return cenaBar; }
        }
        public static int CenaPivovar
        {
            get { return cenaPivovar; }
        }
        #endregion

        #region // Геттер на переменную общее колво бутылок
        public static long ObshayaSummaButilok
        {
            get { return obshayaSummaButilok; }
        }
        #endregion

        //вывод в интерфейс основного окна, подставляя к нему колво опций по каждому виду
        static void kolvoRabov()
        {
            pereraschet();
            Teksti.HELP();
            Console.WriteLine();
            Console.WriteLine($"На вас работают: Алкашей = {kolvoAlkash}; Ларьков = {kolvoLarek}; Баров = {kolvoBar}; Пивоварен = {kolvoPivovar}."); ;

        }
        // производит пересчет бутылок путем суммирования общего колва и бутылок принесенных опцией.
        // каждая опция, приносит бутылки в свою переменную
        //реализовано, что бы не происходила заминка по время плюсавания бутылки от команды пивас
        // и приноса бутылки любой из опцией
        static void pereraschet()
        {
            obshayaSummaButilok = obshayaSummaButilok + tempSumAlkash + tempSumLarek + tempSumBar + tempSumPivovar;
            tempSumAlkash = 0;
            tempSumLarek = 0;
            tempSumBar = 0;
            tempSumPivovar = 0;
        }

    }

}
