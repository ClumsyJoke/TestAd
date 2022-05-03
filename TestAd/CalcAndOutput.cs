using System;
using System.Linq;
using System.Drawing;


namespace TestAd
{
    /* Имеется набор баннеров.
     * Целью является выявление "наибольее эффективного" объявления на основе CTR(отношение кликов к показам)
     * Правило появления того или иного банера определяется исходя из этапа.
     * 1 этап(Набор начальной статистики):
     *  Превые n(?) появлений каждый баннер показываются с одинаковой частотой
     * 2 этап (Использование стратегии)
     *  Исходя из полученных значений, выбор исходя из ширины доверительного интервала
     * 
     * Алгоритм работы
     *  1)Определение выдаваемой картинки
     *  2)Осуществить вывод с увеличением счётчика появления
     *  3)Выдача соответсвуюющей награды
     */
    class CalcAndOutput
    {
        //Набор рекламных объявлений
        Bitmap[] ad = new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3 };
        int bannerCount = 3;
        bool startDataCollected = true;
        int id = 0;

        //Статистика
        private int[] bannerOutput;
        private double[] bannerEarning;
        private double[] bannerInterval;

        //
        int horizont = 10000;

        public int[] BannerOutput { get => bannerOutput; set => bannerOutput = value; }
        public double[] BannerEarning { get => bannerEarning; set => bannerEarning = value; }
        public int Id { get => id; set => id = value; }
        public double[] BannerInterval { get => bannerInterval; set => bannerInterval = value; }

        public CalcAndOutput()
        {
            BannerOutput = new int[bannerCount];
            BannerEarning = new double[bannerCount];
            BannerInterval = new double[bannerCount];
            ImitateDataBase();
        }

        public void ChoiseId()
        {

            if (BannerOutput[2] == 100)
            {
                startDataCollected = true;
                RefreshInterval();
            }
            if (startDataCollected)
            {
                double maxU = BannerInterval.Max();
                Id = Array.IndexOf(BannerInterval, maxU);
                BannerOutput[Id]++;
                int totalCount = bannerOutput[0] + bannerOutput[1] + bannerOutput[2];
                BannerInterval[Id] = BannerEarning[Id] / BannerOutput[Id] + Math.Sqrt(2 * Math.Log(totalCount) / BannerOutput[Id]);
            }
            else
                ChangeBanner();
        }

        void RefreshInterval() 
        {
            int totalCount = bannerOutput[0] + bannerOutput[1] + bannerOutput[2];
            for (int i = 0; i < bannerCount; i++)
            {
                BannerInterval[i] = BannerEarning[i] / BannerOutput[i] + Math.Sqrt(2 * Math.Log(totalCount) / BannerOutput[i]);
            }
        }
        
        public Bitmap ReturnBanner()
        {
            ChoiseId();
            //BannerOutput[Id]++;
            return ad[Id];
        }

        public void ChangeBanner() 
        {
            Id++;
            if (Id > 2)
                Id = 0;
        }
        private void ImitateDataBase()
        {
            Random rnd = new Random();
            BannerOutput[0] = 100;
            BannerOutput[1] = 100;
            BannerOutput[2] = 100;

            BannerEarning[0] = rnd.Next(15, 25);
            BannerEarning[1] = rnd.Next(15, 25);
            BannerEarning[2] = rnd.Next(15, 25);
        }
    }
}
