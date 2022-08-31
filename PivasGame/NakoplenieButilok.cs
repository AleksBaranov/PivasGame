using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivasGame
{
    internal class NakoplenieButilok
    {
        private static string zaprosVConsol;

        private static long obshayaSummaButilok = 0;

        private static int exit = 1;

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

        public static void Funkcional()
        {
            Thread thAlkash = new Thread(nesetAlkash);
                thAlkash.Start();
            Thread thLarek = new Thread(nesetLarek);
                thLarek.Start();
            Thread thBar = new Thread(nesetBar);
                thBar.Start();
            Thread thPivovar = new Thread(nesetPivovar);
                thPivovar.Start();

            zaprosVConsol = Console.ReadLine();
            zaprosVConsol = zaprosVConsol.ToUpper();


            while (zaprosVConsol != "ПНХ")
            {
                if (zaprosVConsol == "ПАМАГИ")
                {
                    Teksti.HELP();
                    zaprosVConsol = null;
                }
                if (zaprosVConsol == "ПИВАС")
                {
                    obshayaSummaButilok++;
                }

                if (zaprosVConsol == "СКОКА ТАМ")
                {
                    obshayaSummaButilok = obshayaSummaButilok + tempSumAlkash + tempSumLarek + tempSumBar + tempSumPivovar ;
                    tempSumAlkash = 0;
                    tempSumLarek = 0;
                    tempSumBar = 0;
                    tempSumPivovar = 0;

                    System.Console.WriteLine($"Ваше колличество бутылок равно: {obshayaSummaButilok}, что позволяет нанять {obshayaSummaButilok / cenaAlkasha} Алкаша или поставить {obshayaSummaButilok / cenaLarek} ларьков, или {obshayaSummaButilok / cenaBar} бар, или {obshayaSummaButilok / cenaPivovar} пивоварня.");
                    System.Console.WriteLine($"Колво Алкашей = {kolvoAlkash}. Колво Ларьков = {kolvoLarek}. Колво Баров = {kolvoBar}. Колво Пивоварен = {kolvoPivovar}."); ;
                }
                if (zaprosVConsol == "АЛКАШ")
                {
                    if (obshayaSummaButilok < 10)
                    {
                        System.Console.WriteLine("У вас не достаточно бутылок. Стоимость Алкаша 10 бутылок.");
                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 10;
                        kolvoAlkash++;
                    }
                }

                if (zaprosVConsol == "ЛАРЕК")
                {
                    if (obshayaSummaButilok < 50)
                    {
                        System.Console.WriteLine("У вас не достаточно бутылок. Стоимость Ларька 50 бутылок.");
                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 50;
                        kolvoLarek++;
                    }
                }

                if (zaprosVConsol == "БАР")
                {
                    if (obshayaSummaButilok < 500)
                    {
                        System.Console.WriteLine("У вас не достаточно бутылок. Стоимость Бара 500 бутылок.");
                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 500;
                        kolvoBar++;
                    }
                }

                if (zaprosVConsol == "ПИВОВАРНЯ")
                {
                    if (obshayaSummaButilok < 500)
                    {
                        System.Console.WriteLine("У вас не достаточно бутылок. Стоимость Пивоварни 3000 бутылок.");
                    }
                    else
                    {
                        obshayaSummaButilok = obshayaSummaButilok - 3000;
                        kolvoPivovar++;
                    }
                }

                zaprosVConsol = Console.ReadLine();
                zaprosVConsol = zaprosVConsol.ToUpper();
            }
            exit = 3;
            thAlkash.Interrupt();
            thLarek.Interrupt();
            thBar.Interrupt();
            thPivovar.Interrupt();
            Console.WriteLine($"{UserProfil.FinishName} игра окончена. Вы набрали: {obshayaSummaButilok} бутылок, \nНаняли {kolvoAlkash} Алкашей и построили {kolvoLarek} ларьков, {kolvoBar} баров, {kolvoPivovar} пивоварню"); ;

        }
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
    }

}
