using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
        private const string optionsFileName = "DifficultyTuningModOptions_v20151015.xml";
        
        public bool Modified = false;
        
        public Difficulties Difficulty;
        
        public ConstructionCostMultiplier ConstructionCostMultiplier;
        public ConstructionCostMultiplier_Road ConstructionCostMultiplier_Road;
        public ConstructionCostMultiplier_Service ConstructionCostMultiplier_Service;
        public ConstructionCostMultiplier_Public ConstructionCostMultiplier_Public;
        public MaintenanceCostMultiplier MaintenanceCostMultiplier;
        public MaintenanceCostMultiplier_Road MaintenanceCostMultiplier_Road;
        public MaintenanceCostMultiplier_Service MaintenanceCostMultiplier_Service;
        public MaintenanceCostMultiplier_Public MaintenanceCostMultiplier_Public;
        public RelocationCostMultiplier RelocationCostMultiplier;
        public AreaCostMultiplier AreaCostMultiplier;
        public InitialMoney InitialMoney;
        public RewardMultiplier RewardMultiplier;
        public DemandOffset DemandOffset;
        public DemandMultiplier DemandMultiplier;
        public ResidentialTargetLandValue ResidentialTargetLandValue;
        public CommercialTargetLandValue CommercialTargetLandValue;
        public IndustrialTargetScore IndustrialTargetScore;
        public OfficeTargetScore OfficeTargetScore;

        private DifficultyManager()
        {
            Difficulty = Difficulties.Normal;
            
            ConstructionCostMultiplier = new ConstructionCostMultiplier();
            ConstructionCostMultiplier_Road = new ConstructionCostMultiplier_Road();
            ConstructionCostMultiplier_Service = new ConstructionCostMultiplier_Service();
            ConstructionCostMultiplier_Public = new ConstructionCostMultiplier_Public();
            MaintenanceCostMultiplier = new MaintenanceCostMultiplier();
            MaintenanceCostMultiplier_Road = new MaintenanceCostMultiplier_Road();
            MaintenanceCostMultiplier_Service = new MaintenanceCostMultiplier_Service();
            MaintenanceCostMultiplier_Public = new MaintenanceCostMultiplier_Public();
            RelocationCostMultiplier = new RelocationCostMultiplier();
            AreaCostMultiplier = new AreaCostMultiplier();
            InitialMoney = new InitialMoney();
            RewardMultiplier = new RewardMultiplier();
            DemandOffset = new DemandOffset();
            DemandMultiplier = new DemandMultiplier();
            ResidentialTargetLandValue = new ResidentialTargetLandValue();
            CommercialTargetLandValue = new CommercialTargetLandValue();
            IndustrialTargetScore = new IndustrialTargetScore();
            OfficeTargetScore = new OfficeTargetScore();

            // Load from file
        }

        public string[] DifficultiesStr
        {
            get
            {
                List<string> sl = new List<string>();

                for (Difficulties d = Difficulties.Free; d <= Difficulties.Custom; d++)
                {
                    sl.Add(DTMLang.Text(d.ToString()));
                }

                return sl.ToArray();
            }
        }
        
        public void Save()
        {
            DifficultyOptionsSerializable options = new DifficultyOptionsSerializable();
            
            options.Difficulty = this.Difficulty;
            options.ConstructionCostMultiplier = this.ConstructionCostMultiplier.CustomValue;
            options.ConstructionCostMultiplier_Road = this.ConstructionCostMultiplier_Road.CustomValue;
            options.ConstructionCostMultiplier_Service = this.ConstructionCostMultiplier_Service.CustomValue;
            options.ConstructionCostMultiplier_Public = this.ConstructionCostMultiplier_Public.CustomValue;
            options.MaintenanceCostMultiplier = this.MaintenanceCostMultiplier.CustomValue;
            options.MaintenanceCostMultiplier_Road = this.MaintenanceCostMultiplier_Road.CustomValue;
            options.MaintenanceCostMultiplier_Service = this.MaintenanceCostMultiplier_Service.CustomValue;
            options.MaintenanceCostMultiplier_Public = this.MaintenanceCostMultiplier_Public.CustomValue;
            options.RelocationCostMultiplier = this.RelocationCostMultiplier.CustomValue;
            options.AreaCostMultiplier = this.AreaCostMultiplier.CustomValue;
            options.InitialMoney = this.InitialMoney.CustomValue;
            options.RewardMultiplier = this.RewardMultiplier.CustomValue;
            options.DemandOffset = this.DemandOffset.CustomValue;
            options.DemandMultiplier = this.DemandMultiplier.CustomValue;
            options.ResidentialTargetLandValueIndex = this.ResidentialTargetLandValueIndex.nCustom;
            options.CommercialTargetLandValueIndex = this.CommercialTargetLandValueIndex.nCustom;
            options.IndustrialTargetScoreIndex = this.IndustrialTargetScoreIndex.nCustom;
            options.OfficeTargetScoreIndex = this.OfficeTargetScoreIndex.nCustom;
            
            options.Save();
            
            Modified = false;
        }
        
        public void Load()
        {
            DifficultyOptionsSerializable options = DifficultyOptionsSerializable.CreateFromFile();
            
            if (options != null)
            {
                this.Difficulty = options.Difficulty;
                this.ConstructionCostMultiplier.CustomValue = options.ConstructionCostMultiplier;
                this.ConstructionCostMultiplier_Road.CustomValue = options.ConstructionCostMultiplier_Road;
                this.ConstructionCostMultiplier_Service.CustomValue = options.ConstructionCostMultiplier_Service;
                this.ConstructionCostMultiplier_Public.CustomValue = options.ConstructionCostMultiplier_Public;
                this.MaintenanceCostMultiplier.CustomValue = options.MaintenanceCostMultiplier;
                this.MaintenanceCostMultiplier_Road.CustomValue = options.MaintenanceCostMultiplier_Road;
                this.MaintenanceCostMultiplier_Service.CustomValue = options.MaintenanceCostMultiplier_Service;
                this.MaintenanceCostMultiplier_Public.CustomValue = options.MaintenanceCostMultiplier_Public;
                this.RelocationCostMultiplier.CustomValue = options.RelocationCostMultiplier;
                this.AreaCostMultiplier.CustomValue = options.AreaCostMultiplier;
                this.InitialMoney.CustomValue = options.InitialMoney;
                this.RewardMultiplier.CustomValue = options.RewardMultiplier;
                this.DemandOffset.CustomValue = options.DemandOffset;
                this.DemandMultiplier.CustomValue = options.DemandMultiplier;
                this.ResidentialTargetLandValueIndex.nCustom = options.ResidentialTargetLandValueIndex;
                this.CommercialTargetLandValueIndex.nCustom = options.CommercialTargetLandValueIndex;
                this.IndustrialTargetScoreIndex.nCustom = options.IndustrialTargetScoreIndex;
                this.OfficeTargetScoreIndex.nCustom = options.OfficeTargetScoreIndex;
            }
        }
    }
}