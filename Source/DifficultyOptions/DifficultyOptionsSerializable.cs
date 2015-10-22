using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;

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

        [DefaultValue(100)]
        public int PopulationTargetMultiplier;

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