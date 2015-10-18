using System.IO;
using System.Xml.Serialization;
using ColossalFramework.Plugins;

namespace DifficultyTuningMod.DifficultyOptions_old
{
    public class DifficultyOptions
    {
        private const string optionsFileName = "DifficultyTuningModOptions.xml";
        
        public Difficulties Difficulty;
        
        public int ConstructionCostMultiplierIndex;
        public int RoadConstructionCostMultiplierIndex;
        public int MaintenanceCostMultiplierIndex;
        public int RoadMaintenanceCostMultiplierIndex;
        public int DemandOffsetIndex;
        public int DemandMultiplierIndex;
        public int AreaCostMultiplierIndex;
        public int RewardMultiplierIndex;
        public int RelocationCostMultiplierIndex;
        public int ResidentialTargetLandValueIndex;
        public int ResidentialTooLowLandValueIndex;
        public int CommercialTargetLandValueIndex;
        public int CommercialTooLowLandValueIndex;
        public int IndustrialTargetServiceIndex;
        public int IndustrialTooFewServiceIndex;
        public int OfficeTargetServiceIndex;
        public int OfficeTooFewServiceIndex;
        
        public static DifficultyOptions TryCreateFromFile()
        {
            if (!File.Exists(optionsFileName)) return null;

            //DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "1");
            XmlSerializer ser = new XmlSerializer(typeof(DifficultyOptions));
            TextReader reader = new StreamReader(optionsFileName);
            DifficultyOptions instance = (DifficultyOptions)ser.Deserialize(reader);
            reader.Close();

            return instance;
        }
        
        public void DeleteOptionsFile()
        {
            try
            {
                File.Delete(optionsFileName);
            }
            catch
            {
                // Ignore
            }
        }
        
        public float getConstructionCostMultiplier()
        {
            switch ((Difficulties)ConstructionCostMultiplierIndex)
            {
                case Difficulties.Easy:
                    return 0.5f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Medium:
                    return 1.1f;
                case Difficulties.Hard:
                    return 1.25f;
                case Difficulties.Advanced:
                    return 1.5f;
                case Difficulties.Expert:
                    return 2f;
                case Difficulties.Challenge:
                    return 3f;
                case Difficulties.Impossible:
                    return 5f;
            }

            return 1f;
        }
        
        public float getRoadConstructionCostMultiplier()
        {
            switch ((Difficulties)RoadConstructionCostMultiplierIndex)
            {
                case Difficulties.Easy:
                    return 0.5f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Medium:
                    return 1.2f;
                case Difficulties.Hard:
                    return 1.5f;
                case Difficulties.Advanced:
                    return 2f;
                case Difficulties.Expert:
                    return 3f;
                case Difficulties.Challenge:
                    return 5f;
                case Difficulties.Impossible:
                    return 8f;
            }

            return 1f;
        }
        
        public float getMaintenanceCostMultiplier()
        {
            switch ((Difficulties)MaintenanceCostMultiplierIndex)
            {
                case Difficulties.Easy:
                    return 0.5f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Medium:
                    return 1.1f;
                case Difficulties.Hard:
                    return 1.25f;
                case Difficulties.Advanced:
                    return 1.4f;
                case Difficulties.Expert:
                    return 1.6f;
                case Difficulties.Challenge:
                    return 1.8f;
                case Difficulties.Impossible:
                    return 2f;
            }

            return 1f;
        }
        
        public float getRoadMaintenanceCostMultiplier()
        {
            switch ((Difficulties)RoadMaintenanceCostMultiplierIndex)
            {
                case Difficulties.Easy:
                    return 0.5f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Medium:
                    return 1.2f;
                case Difficulties.Hard:
                    return 1.4f;
                case Difficulties.Advanced:
                    return 1.6f;
                case Difficulties.Expert:
                    return 2f;
                case Difficulties.Challenge:
                    return 2.5f;
                case Difficulties.Impossible:
                    return 3f;
            }

            return 1f;
        }
        
        public int getDemandOffset()
        {
            switch ((Difficulties)DemandOffsetIndex)
            {
                case Difficulties.Easy:
                    return 10;
                case Difficulties.Normal:
                    return 0;
                case Difficulties.Medium:
                    return -10;
                case Difficulties.Hard:
                    return -15;
                case Difficulties.Advanced:
                    return -18;
                case Difficulties.Expert:
                    return -20;
                case Difficulties.Challenge:
                    return -21;
                case Difficulties.Impossible:
                    return -22;
            }

            return 0;
        }
        
        public float getDemandMultiplier()
        {
            switch ((Difficulties)DemandMultiplierIndex)
            {
                case Difficulties.Easy:
                    return 1.1f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Medium:
                    return 1f;
                case Difficulties.Hard:
                    return 0.95f;
                case Difficulties.Advanced:
                    return 0.9f;
                case Difficulties.Expert:
                    return 0.85f;
                case Difficulties.Challenge:
                    return 0.8f;
                case Difficulties.Impossible:
                    return 0.75f;
            }

            return 1f;
        }
        
        public float getAreaCostMultiplier()
        {
            switch ((Difficulties)AreaCostMultiplierIndex)
            {
                case Difficulties.Easy:
                    return 0.5f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Medium:
                    return 2f;
                case Difficulties.Hard:
                    return 3f;
                case Difficulties.Advanced:
                    return 5f;
                case Difficulties.Expert:
                    return 10f;
                case Difficulties.Challenge:
                    return 15f;
                case Difficulties.Impossible:
                    return 20f;
            }

            return 1f;
        }
        
        public float getRewardMultiplier()
        {
            switch ((Difficulties)RewardMultiplierIndex)
            {
                case Difficulties.Easy:
                    return 2f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Medium:
                    return 0.75f;
                case Difficulties.Hard:
                    return 0.5f;
                case Difficulties.Advanced:
                    return 0.25f;
                case Difficulties.Expert:
                    return 0f;
                case Difficulties.Challenge:
                    return 0f;
                case Difficulties.Impossible:
                    return 0f;
            }

            return 1f;
        }
        
        public float getRelocationCostMultiplier()
        {
            return System.Math.Min(0.9f, 0.2f * RelocationCostMultiplierIndex);
        }
    }
}
