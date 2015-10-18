//using System.Collections.Generic;
//using System.IO;
//using System.Xml.Serialization;
//using ICities;

//namespace DifficultyTuningMod
//{
//    public class DifficultyOptions_old
//    {
//        private static DifficultyOptions_old _instance = null;
//        public static DifficultyOptions_old Instance
//        {
//            get
//            {
//                //if (_instance == null)
//                //{
//                //    if (File.Exists(fileName))
//                //    {
//                //        XmlSerializer ser = new XmlSerializer(typeof(DifficultyOptions));
//                //        TextReader reader = new StreamReader(fileName);
//                //        _instance = (DifficultyOptions)ser.Deserialize(reader);
//                //        reader.Close();
//                //    }
//                //    else
//                //    {
//                //        _instance = new DifficultyOptions();
//                //    }
//                //}

//                return _instance;
//            }
//        }

//        //private const string fileName = "DifficultyTuningModOptions.xml";

//        //private DifficultyOptions() { }

//        public static void Save()
//        {
//            //XmlSerializer ser = new XmlSerializer(typeof(DifficultyOptions));
//            //TextWriter writer = new StreamWriter(fileName);
//            //ser.Serialize(writer, Instance);
//            //writer.Close();

//            //UIPanel electricityGroupPanel = UIView.Find<UIPanel>("ElectricityGroupPanel");
//            //if (electricityGroupPanel == null)
//            //{
//            //    DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Did not find ElectricityGroupPanel");
//            //}
//            //else
//            //{
//            //    electricityGroupPanel.Update();
//            //}
//        }

//        private static string getPercentStringFromMultiplier(float m)
//        {
//            return (m * 100).ToString() + "%";
//        }

//        public Difficulties Difficulty = Difficulties.Normal;
//        public static Difficulties GameDifficulty
//        {
//            get
//            {
//                return Instance.Difficulty;
//            }
//        }
//        public static string[] DifficultyList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (Difficulties d = Difficulties.Easy; d <= Difficulties.Custom; d++)
//                {
//                    sl.Add(DTMLang.Text(d.ToString()));
//                }

//                return sl.ToArray();
//            }
//        }

//        #region ConstructionCost
//        public int ConstructionCostMultiplierIndex = 1;
//        private float getConstructionCostMultiplier(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 0.5f;
//                case Difficulties.Normal:
//                    return 1f;
//                case Difficulties.Medium:
//                    return 1.1f;
//                case Difficulties.Hard:
//                    return 1.25f;
//                case Difficulties.Advanced:
//                    return 1.5f;
//                case Difficulties.Expert:
//                    return 2f;
//                case Difficulties.Challenge:
//                    return 3f;
//                case Difficulties.Impossible:
//                    return 5f;
//            }

//            return 1f;
//        }
//        public static float ConstructionCostMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ConstructionCostMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getConstructionCostMultiplier(n);
//            }
//        }
//        public static string[] ConstructionCostMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(getPercentStringFromMultiplier(Instance.getConstructionCostMultiplier(i)));
//                }

//                return sl.ToArray();
//            }
//        }

//        public int RoadConstructionCostMultiplierIndex = 1;
//        private float getRoadConstructionCostMultiplier(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 0.5f;
//                case Difficulties.Normal:
//                    return 1f;
//                case Difficulties.Medium:
//                    return 1.2f;
//                case Difficulties.Hard:
//                    return 1.5f;
//                case Difficulties.Advanced:
//                    return 2f;
//                case Difficulties.Expert:
//                    return 3f;
//                case Difficulties.Challenge:
//                    return 5f;
//                case Difficulties.Impossible:
//                    return 8f;
//            }

//            return 1f;
//        }
//        public static float RoadConstructionCostMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.RoadConstructionCostMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getRoadConstructionCostMultiplier(n);
//            }
//        }
//        public static string[] RoadConstructionCostMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(getPercentStringFromMultiplier(Instance.getRoadConstructionCostMultiplier(i)));
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region MaintenanceCost
//        public int MaintenanceCostMultiplierIndex = 1;
//        private float getMaintenanceCostMultiplier(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 0.5f;
//                case Difficulties.Normal:
//                    return 1f;
//                case Difficulties.Medium:
//                    return 1.1f;
//                case Difficulties.Hard:
//                    return 1.25f;
//                case Difficulties.Advanced:
//                    return 1.4f;
//                case Difficulties.Expert:
//                    return 1.6f;
//                case Difficulties.Challenge:
//                    return 1.8f;
//                case Difficulties.Impossible:
//                    return 2f;
//            }

//            return 1f;
//        }
//        public static float MaintenanceCostMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.MaintenanceCostMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getMaintenanceCostMultiplier(n);
//            }
//        }
//        public static string[] MaintenanceCostMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(getPercentStringFromMultiplier(Instance.getMaintenanceCostMultiplier(i)));
//                }

//                return sl.ToArray();
//            }
//        }

//        public int RoadMaintenanceCostMultiplierIndex = 1;
//        private float getRoadMaintenanceCostMultiplier(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 0.5f;
//                case Difficulties.Normal:
//                    return 1f;
//                case Difficulties.Medium:
//                    return 1.2f;
//                case Difficulties.Hard:
//                    return 1.4f;
//                case Difficulties.Advanced:
//                    return 1.6f;
//                case Difficulties.Expert:
//                    return 2f;
//                case Difficulties.Challenge:
//                    return 2.5f;
//                case Difficulties.Impossible:
//                    return 3f;
//            }

//            return 1f;
//        }
//        public static float RoadMaintenanceCostMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.RoadMaintenanceCostMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getRoadMaintenanceCostMultiplier(n);
//            }
//        }
//        public static string[] RoadMaintenanceCostMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(getPercentStringFromMultiplier(Instance.getRoadMaintenanceCostMultiplier(i)));
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region Demand
//        public int DemandOffsetIndex = 1;
//        private int getDemandOffset(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 10;
//                case Difficulties.Normal:
//                    return 0;
//                case Difficulties.Medium:
//                    return -10;
//                case Difficulties.Hard:
//                    return -15;
//                case Difficulties.Advanced:
//                    return -18;
//                case Difficulties.Expert:
//                    return -20;
//                case Difficulties.Challenge:
//                    return -21;
//                case Difficulties.Impossible:
//                    return -22;
//            }

//            return 0;
//        }
//        public static int DemandOffset
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.DemandOffsetIndex : (int)Instance.Difficulty;

//                return Instance.getDemandOffset(n);
//            }
//        }
//        public static string[] DemandOffsetList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(Instance.getDemandOffset(i).ToString());
//                }

//                return sl.ToArray();
//            }
//        }

//        public int DemandMultiplierIndex = 1;
//        private float getDemandMultiplier(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 1.1f;
//                case Difficulties.Normal:
//                    return 1f;
//                case Difficulties.Medium:
//                    return 1f;
//                case Difficulties.Hard:
//                    return 0.95f;
//                case Difficulties.Advanced:
//                    return 0.9f;
//                case Difficulties.Expert:
//                    return 0.85f;
//                case Difficulties.Challenge:
//                    return 0.8f;
//                case Difficulties.Impossible:
//                    return 0.75f;
//            }

//            return 1f;
//        }
//        public static float DemandMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.DemandMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getDemandMultiplier(n);
//            }
//        }
//        public static string[] DemandMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(Instance.getDemandMultiplier(i).ToString());
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region Area
//        public int AreaCostMultiplierIndex = 1;
//        private float getAreaCostMultiplier(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 0.5f;
//                case Difficulties.Normal:
//                    return 1f;
//                case Difficulties.Medium:
//                    return 2f;
//                case Difficulties.Hard:
//                    return 3f;
//                case Difficulties.Advanced:
//                    return 5f;
//                case Difficulties.Expert:
//                    return 10f;
//                case Difficulties.Challenge:
//                    return 15f;
//                case Difficulties.Impossible:
//                    return 20f;
//            }

//            return 1f;
//        }
//        public static float AreaCostMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.AreaCostMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getAreaCostMultiplier(n);
//            }
//        }
//        public static string[] AreaCostMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add("x" + Instance.getAreaCostMultiplier(i).ToString());
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region RewardMultiplier
//        public int RewardMultiplierIndex = 1;
//        private float getRewardMultiplier(int n)
//        {
//            switch ((Difficulties)n)
//            {
//                case Difficulties.Easy:
//                    return 2f;
//                case Difficulties.Normal:
//                    return 1f;
//                case Difficulties.Medium:
//                    return 0.75f;
//                case Difficulties.Hard:
//                    return 0.5f;
//                case Difficulties.Advanced:
//                    return 0.25f;
//                case Difficulties.Expert:
//                    return 0f;
//                case Difficulties.Challenge:
//                    return 0f;
//                case Difficulties.Impossible:
//                    return 0f;
//            }

//            return 1f;
//        }
//        public static float RewardMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.RewardMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getRewardMultiplier(n);
//            }
//        }
//        public static string[] RewardMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(getPercentStringFromMultiplier(Instance.getRewardMultiplier(i)));
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region RelocationCostMultiplier
//        public int RelocationCostMultiplierIndex = 1;
//        private float getRelocationCostMultiplier(int n)
//        {
//            return System.Math.Min(0.9f, 0.2f * n);
//        }
//        public static float RelocationCostMultiplier
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.RelocationCostMultiplierIndex : (int)Instance.Difficulty;

//                return Instance.getRelocationCostMultiplier(n);
//            }
//        }
//        public static string[] RelocationCostMultiplierList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(getPercentStringFromMultiplier(Instance.getRelocationCostMultiplier(i)));
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region ResidentialTargetLandValue
//        public int ResidentialTargetLandValueIndex = 1;
//        private int getResidentialTargetLandValue(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return 2 + 4 * n;
//                case Level.Level3:
//                    return 14 + 7 * n;
//                case Level.Level4:
//                    return 31 + 10 * n;
//                case Level.Level5:
//                    return 49 + 12 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong residential building level");
//        }
//        public static int ResidentialTargetLandValueLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTargetLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTargetLandValue(n, Level.Level2);
//            }
//        }
//        public static int ResidentialTargetLandValueLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTargetLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTargetLandValue(n, Level.Level3);
//            }
//        }
//        public static int ResidentialTargetLandValueLevel4
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTargetLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTargetLandValue(n, Level.Level4);
//            }
//        }
//        public static int ResidentialTargetLandValueLevel5
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTargetLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTargetLandValue(n, Level.Level5);
//            }
//        }
//        public static string[] ResidentialTargetLandValueList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(
//                        Instance.getResidentialTargetLandValue(i, Level.Level2).ToString() + ", " +
//                        Instance.getResidentialTargetLandValue(i, Level.Level3).ToString() + ", " +
//                        Instance.getResidentialTargetLandValue(i, Level.Level4).ToString() + ", " +
//                        Instance.getResidentialTargetLandValue(i, Level.Level5).ToString()
//                        );
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region ResidentialTooLowLandValue
//        public int ResidentialTooLowLandValueIndex = 1;
//        private int getResidentialTooLowLandValue(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return -1 + 2 * n;
//                case Level.Level3:
//                    return 6 + 5 * n;
//                case Level.Level4:
//                    return 23 + 8 * n;
//                case Level.Level5:
//                    return 41 + 10 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong residential building level");
//        }
//        public static int ResidentialTooLowLandValueLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTooLowLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTooLowLandValue(n, Level.Level2);
//            }
//        }
//        public static int ResidentialTooLowLandValueLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTooLowLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTooLowLandValue(n, Level.Level3);
//            }
//        }
//        public static int ResidentialTooLowLandValueLevel4
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTooLowLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTooLowLandValue(n, Level.Level4);
//            }
//        }
//        public static int ResidentialTooLowLandValueLevel5
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.ResidentialTooLowLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getResidentialTooLowLandValue(n, Level.Level5);
//            }
//        }
//        #endregion

//        #region CommercialTargetLandValue
//        public int CommercialTargetLandValueIndex = 1;
//        private int getCommercialTargetLandValue(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return 16 + 5 * n;
//                case Level.Level3:
//                    return 31 + 10 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong Commercial building level");
//        }
//        public static int CommercialTargetLandValueLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.CommercialTargetLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getCommercialTargetLandValue(n, Level.Level2);
//            }
//        }
//        public static int CommercialTargetLandValueLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.CommercialTargetLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getCommercialTargetLandValue(n, Level.Level3);
//            }
//        }
//        public static string[] CommercialTargetLandValueList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(
//                        Instance.getCommercialTargetLandValue(i, Level.Level2).ToString() + ", " +
//                        Instance.getCommercialTargetLandValue(i, Level.Level3).ToString()
//                        );
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region CommercialTooLowLandValue
//        public int CommercialTooLowLandValueIndex = 1;
//        private int getCommercialTooLowLandValue(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return 6 + 4 * n;
//                case Level.Level3:
//                    return 22 + 8 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong Commercial building level");
//        }
//        public static int CommercialTooLowLandValueLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.CommercialTooLowLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getCommercialTooLowLandValue(n, Level.Level2);
//            }
//        }
//        public static int CommercialTooLowLandValueLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.CommercialTooLowLandValueIndex : (int)Instance.Difficulty;

//                return Instance.getCommercialTooLowLandValue(n, Level.Level3);
//            }
//        }
//        #endregion

//        #region IndustrialTargetService
//        public int IndustrialTargetServiceIndex = 1;
//        private int getIndustrialTargetService(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return 25 + 5 * n;
//                case Level.Level3:
//                    return 50 + 10 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong Industrial building level");
//        }
//        public static int IndustrialTargetServiceLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.IndustrialTargetServiceIndex : (int)Instance.Difficulty;

//                return Instance.getIndustrialTargetService(n, Level.Level2);
//            }
//        }
//        public static int IndustrialTargetServiceLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.IndustrialTargetServiceIndex : (int)Instance.Difficulty;

//                return Instance.getIndustrialTargetService(n, Level.Level3);
//            }
//        }
//        public static string[] IndustrialTargetServiceList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(
//                        Instance.getIndustrialTargetService(i, Level.Level2).ToString() + ", " +
//                        Instance.getIndustrialTargetService(i, Level.Level3).ToString()
//                        );
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region IndustrialTooFewService
//        public int IndustrialTooFewServiceIndex = 1;
//        private int getIndustrialTooFewService(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return 16 + 4 * n;
//                case Level.Level3:
//                    return 32 + 8 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong Industrial building level");
//        }
//        public static int IndustrialTooFewServiceLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.IndustrialTooFewServiceIndex : (int)Instance.Difficulty;

//                return Instance.getIndustrialTooFewService(n, Level.Level2);
//            }
//        }
//        public static int IndustrialTooFewServiceLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.IndustrialTooFewServiceIndex : (int)Instance.Difficulty;

//                return Instance.getIndustrialTooFewService(n, Level.Level3);
//            }
//        }
//        #endregion

//        #region OfficeTargetService
//        public int OfficeTargetServiceIndex = 1;
//        private int getOfficeTargetService(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return 40 + 5 * n;
//                case Level.Level3:
//                    return 80 + 10 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong Office building level");
//        }
//        public static int OfficeTargetServiceLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.OfficeTargetServiceIndex : (int)Instance.Difficulty;

//                return Instance.getOfficeTargetService(n, Level.Level2);
//            }
//        }
//        public static int OfficeTargetServiceLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.OfficeTargetServiceIndex : (int)Instance.Difficulty;

//                return Instance.getOfficeTargetService(n, Level.Level3);
//            }
//        }
//        public static string[] OfficeTargetServiceList
//        {
//            get
//            {
//                List<string> sl = new List<string>();

//                for (int i = (int)Difficulties.Easy; i < (int)Difficulties.Custom; i++)
//                {
//                    sl.Add(
//                        Instance.getOfficeTargetService(i, Level.Level2).ToString() + ", " +
//                        Instance.getOfficeTargetService(i, Level.Level3).ToString()
//                        );
//                }

//                return sl.ToArray();
//            }
//        }
//        #endregion

//        #region OfficeTooFewService
//        public int OfficeTooFewServiceIndex = 1;
//        private int getOfficeTooFewService(int n, Level level)
//        {
//            switch (level)
//            {
//                case Level.Level2:
//                    return 26 + 4 * n;
//                case Level.Level3:
//                    return 52 + 8 * n;
//            }

//            throw new System.Exception("[DifficultyTuningMod]: Wrong Office building level");
//        }
//        public static int OfficeTooFewServiceLevel2
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.OfficeTooFewServiceIndex : (int)Instance.Difficulty;

//                return Instance.getOfficeTooFewService(n, Level.Level2);
//            }
//        }
//        public static int OfficeTooFewServiceLevel3
//        {
//            get
//            {
//                int n = (Instance.Difficulty == Difficulties.Custom) ? Instance.OfficeTooFewServiceIndex : (int)Instance.Difficulty;

//                return Instance.getOfficeTooFewService(n, Level.Level3);
//            }
//        }
//        #endregion
//    }
//}
