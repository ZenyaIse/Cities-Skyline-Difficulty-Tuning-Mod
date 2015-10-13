using System.Collections.Generic;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
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
        //public AreaCostMultiplierClass AreaCostMultiplier;
        //public DemandOffsetClass DemandOffset;
        //public DemandMultiplierClass DemandMultiplier;
        //public RewardMultiplierClass RewardMultiplier;
        //public ResidentialTargetLandValueClass ResidentialTargetLandValue;
        //public CommercialTargetLandValueClass CommercialTargetLandValue;
        //public IndustrialTargetServiceClass IndustrialTargetService;
        //public OfficeTargetServiceClass OfficeTargetService;

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
            //AreaCostMultiplier = new AreaCostMultiplierClass();
            //DemandOffset = new DemandOffsetClass();
            //DemandMultiplier = new DemandMultiplierClass();
            //RewardMultiplier = new RewardMultiplierClass();
            //ResidentialTargetLandValue = new ResidentialTargetLandValueClass();
            //CommercialTargetLandValue = new CommercialTargetLandValueClass();
            //IndustrialTargetService = new IndustrialTargetServiceClass();
            //OfficeTargetService = new OfficeTargetServiceClass();

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
    }
}