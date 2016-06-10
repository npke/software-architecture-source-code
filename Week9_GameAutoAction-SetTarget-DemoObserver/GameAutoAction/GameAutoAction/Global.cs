using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameAutoAction
{
    public class Global
    {
        public static int Turn = 1;
        public static int Food = 0;
        public static int nVillagers = 0;
        public static bool IsBuildingWonder = false;
        public static int TurnsToBuildWonder = 40;

        public static int FoodToRecruitAVillager = 30;
        public static int FoodProducedInATurn = 4;
        public static int nVillagersToBuildWonder = 10;
        public static Farm farm = new Farm();

        internal static void ProduceFood()
        {
            farm.ProduceFood();
            OnProduceFoodFinished();
        }

        private static void OnProduceFoodFinished()
        {
            if (Food >= FoodToRecruitAVillager)
                RecruitAVillager();
        }
        private static List<Villager> villagers = new List<Villager>();

        public static Form1 CurrentForm = null;
        public static Wonder wonder = null;
        public static void BuildWonder()
        {
            wonder.BuildInATurn();
        }

        private static void RecruitAVillager()
        {
            Food -= FoodToRecruitAVillager;
            villagers.Add(new Villager());
            nVillagers++;
            OnRecruitAVillagerFinished();
        }

        private static void OnRecruitAVillagerFinished()
        {
            if (IsBuildingWonder==false)
            if (nVillagers >= nVillagersToBuildWonder)
                StartBuildWonder();
        }

        private static void StartBuildWonder()
        {
            IsBuildingWonder = true;
            wonder = new Wonder();
        }
    }
}