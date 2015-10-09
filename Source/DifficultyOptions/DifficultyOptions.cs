namespace DifficultyTuningMod
{
    public class DifficultyOptions : Singleton<DifficultyOptions>
    {
        public Difficulties Difficulty;
        
        public ConstructionCostMultiplierClass ConstructionCostMultiplier;
        public RoadConstructionCostMultiplierClass RoadConstructionCostMultiplier;
        public MaintenanceCostMultiplierClass MaintenanceCostMultiplier;
        public RoadMaintenanceCostMultiplierClass RoadMaintenanceCostMultiplier;
        public AreaCostMultiplierClass AreaCostMultiplier;
        public DemandOffsetClass DemandOffset;
        public DemandMultiplierClass DemandMultiplier;
        public RewardMultiplierClass RewardMultiplier;
        public RelocationCostMultiplierClass RelocationCostMultiplier;
        public ResidentialTargetLandValueClass ResidentialTargetLandValue;
        public CommercialTargetLandValueClass CommercialTargetLandValue;
        public IndustrialTargetServiceClass IndustrialTargetService;
        public OfficeTargetServiceClass OfficeTargetService;
		
		public override Start()
		{
			Difficulty = Difficulties.Normal;
			
			ConstructionCostMultiplier = new ConstructionCostMultiplierClass();
			RoadConstructionCostMultiplier = new RoadConstructionCostMultiplierClass();
			MaintenanceCostMultiplier = new MaintenanceCostMultiplierClass();
			RoadMaintenanceCostMultiplier = new RoadMaintenanceCostMultiplierClass();
			AreaCostMultiplier = new AreaCostMultiplierClass();
			DemandOffset = new DemandOffsetClass();
			DemandMultiplier = new DemandMultiplierClass();
			RewardMultiplier = new RewardMultiplierClass();
			RelocationCostMultiplier = new RelocationCostMultiplierClass();
			ResidentialTargetLandValue = new ResidentialTargetLandValueClass();
			CommercialTargetLandValue = new CommercialTargetLandValueClass();
			IndustrialTargetService = new IndustrialTargetServiceClass();
			OfficeTargetService = new OfficeTargetServiceClass();
			
			// Load from file
		}
		
		public string[] DifficultiesStr
        {
            get
            {
                List<string> sl = new List<string>();

                for (Difficulties d = Difficulties.Easy; d <= Difficulties.Custom; d++)
                {
                    sl.Add(DTMLang.Text(d.ToString()));
                }

                return sl.ToArray();
            }
        }
    }
}