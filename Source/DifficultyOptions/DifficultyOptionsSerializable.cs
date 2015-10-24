using System.IO;
using System.Xml.Serialization;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class DifficultyOptionsSerializable
    {
        private const string optionsFileName = "DifficultyTuningModOptions_v2.xml";
        
        public Difficulties Difficulty;
        
        public int ConstructionCostMultiplier;
        public int ConstructionCostMultiplier_Road;
        public int ConstructionCostMultiplier_Service;
        public int ConstructionCostMultiplier_Public;
        public int MaintenanceCostMultiplier;
        public int MaintenanceCostMultiplier_Road;
        public int MaintenanceCostMultiplier_Service;
        public int MaintenanceCostMultiplier_Public;
        public int RelocationCostMultiplier;
        public int AreaCostMultiplier;
        public int InitialMoney;
        public int RewardMultiplier;
        public int DemandOffset;
        public int DemandMultiplier;
        public int ResidentialTargetLandValueIndex;
        public int CommercialTargetLandValueIndex;
        public int IndustrialTargetScoreIndex;
        public int OfficeTargetScoreIndex;
        public int PopulationTargetMultiplier;
        public int LoanMultiplier;

        public DifficultyOptionsSerializable()
        {
            // Set default values in case of an xml tag is missing
            ConstructionCostMultiplier = 100;
            ConstructionCostMultiplier_Road = 100;
            ConstructionCostMultiplier_Service = 100;
            ConstructionCostMultiplier_Public = 100;
            MaintenanceCostMultiplier = 100;
            MaintenanceCostMultiplier_Road = 100;
            MaintenanceCostMultiplier_Service = 100;
            MaintenanceCostMultiplier_Public = 100;
            RelocationCostMultiplier = 100;
            AreaCostMultiplier = 10;
            InitialMoney = 70;
            RewardMultiplier = 100;
            DemandOffset = 0;
            DemandMultiplier = 100;
            ResidentialTargetLandValueIndex = 1;
            CommercialTargetLandValueIndex = 1;
            IndustrialTargetScoreIndex = 1;
            OfficeTargetScoreIndex = 1;
            PopulationTargetMultiplier = 100;
            LoanMultiplier = 100;
        }

    public void Save()
        {
            XmlSerializer ser = new XmlSerializer(typeof(DifficultyOptionsSerializable));
            TextWriter writer = new StreamWriter(optionsFileName);
            ser.Serialize(writer, this);
            writer.Close();
        }
        
        public static DifficultyOptionsSerializable CreateFromFile()
        {
            if (!File.Exists(optionsFileName)) return null;
            
            XmlSerializer ser = new XmlSerializer(typeof(DifficultyOptionsSerializable));
            TextReader reader = new StreamReader(optionsFileName);
            DifficultyOptionsSerializable instance = (DifficultyOptionsSerializable)ser.Deserialize(reader);
            reader.Close();
            
            return instance;
        }
    }
}