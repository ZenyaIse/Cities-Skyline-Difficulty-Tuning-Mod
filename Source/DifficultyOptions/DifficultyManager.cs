using System.Collections.Generic;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
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
        public PopulationTargetMultiplier PopulationTargetMultiplier;
        public LoanMultiplier LoanMultiplier;
        public GroundPollutionRadiusMultiplier GroundPollutionRadiusMultiplier;
        public NoisePollutionRadiusMultiplier NoisePollutionRadiusMultiplier;
        public MaxSlope MaxSlope;

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
            PopulationTargetMultiplier = new PopulationTargetMultiplier();
            LoanMultiplier = new LoanMultiplier();
            GroundPollutionRadiusMultiplier = new GroundPollutionRadiusMultiplier();
            NoisePollutionRadiusMultiplier = new NoisePollutionRadiusMultiplier();
            MaxSlope = new MaxSlope();

            Load();
        }

        public string[] DifficultiesStr
        {
            get
            {
                List<string> sl = new List<string>();

                for (Difficulties d = Difficulties.Easy; d <= Difficulties.HardAndFast; d++)
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
            options.ResidentialTargetLandValueIndex = this.ResidentialTargetLandValue.nCustom;
            options.CommercialTargetLandValueIndex = this.CommercialTargetLandValue.nCustom;
            options.IndustrialTargetScoreIndex = this.IndustrialTargetScore.nCustom;
            options.OfficeTargetScoreIndex = this.OfficeTargetScore.nCustom;
            options.PopulationTargetMultiplier = this.PopulationTargetMultiplier.CustomValue;
            options.LoanMultiplier = this.LoanMultiplier.CustomValue;
            options.GroundPollutionRadiusMultiplier = this.GroundPollutionRadiusMultiplier.CustomValue;
            options.NoisePollutionRadiusMultiplier = this.NoisePollutionRadiusMultiplier.CustomValue;
            options.MaxSlope = this.MaxSlope.CustomValue;

            options.Save();
            
            Modified = false;
        }
        
        public void Load()
        {
            DifficultyOptionsSerializable options = DifficultyOptionsSerializable.CreateFromFile();
            
            if (options == null)
            {
                // Force to save if the options file does not exist yet.
                Modified = true;
            }
            else
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
                this.ResidentialTargetLandValue.nCustom = options.ResidentialTargetLandValueIndex;
                this.CommercialTargetLandValue.nCustom = options.CommercialTargetLandValueIndex;
                this.IndustrialTargetScore.nCustom = options.IndustrialTargetScoreIndex;
                this.OfficeTargetScore.nCustom = options.OfficeTargetScoreIndex;
                this.PopulationTargetMultiplier.CustomValue = options.PopulationTargetMultiplier;
                this.LoanMultiplier.CustomValue = options.LoanMultiplier;
                this.GroundPollutionRadiusMultiplier.CustomValue = options.GroundPollutionRadiusMultiplier;
                this.NoisePollutionRadiusMultiplier.CustomValue = options.NoisePollutionRadiusMultiplier;
                this.MaxSlope.CustomValue = options.MaxSlope;
            }
        }
    }
}