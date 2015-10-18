using ICities;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public class LevelUp : LevelUpExtensionBase
    {
        public override ResidentialLevelUp OnCalculateResidentialLevelUp(ResidentialLevelUp levelUp, int averageEducation, int landValue, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (levelUp.landValueProgress != 0)
            {
                Level targetLevel;

                int target2 = d.ResidentialTargetLandValue.GetValue(Level.Level2);
                int target3 = d.ResidentialTargetLandValue.GetValue(Level.Level3);
                int target4 = d.ResidentialTargetLandValue.GetValue(Level.Level4);
                int target5 = d.ResidentialTargetLandValue.GetValue(Level.Level5);

                if (landValue < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.landValueProgress = 1 + (int)(15f * landValue / target2 + 0.49f);
                }
                else if (landValue < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target2) / (target3 - target2) + 0.49f);
                }
                else if (landValue < target4)
                {
                    targetLevel = Level.Level3;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target3) / (target4 - target3) + 0.49f);
                }
                else if (landValue < target5)
                {
                    targetLevel = Level.Level4;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target4) / (target5 - target4) + 0.49f);
                }
                else
                {
                    targetLevel = Level.Level5;
                    levelUp.landValueProgress = 1;
                }

                if (targetLevel < currentLevel)
                {
                    levelUp.landValueProgress = 1;
                }
                else if (targetLevel > currentLevel)
                {
                    levelUp.landValueProgress = 15;
                }

                if (targetLevel < levelUp.targetLevel)
                {
                    levelUp.targetLevel = targetLevel;
                }
            }

            levelUp.landValueTooLow = false;
            if (currentLevel == Level.Level2)
            {
                if (landValue < d.ResidentialTargetLandValue.GetTooLowValue(Level.Level2)) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (landValue < d.ResidentialTargetLandValue.GetTooLowValue(Level.Level3)) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level4)
            {
                if (landValue < d.ResidentialTargetLandValue.GetTooLowValue(Level.Level4)) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level5)
            {
                if (landValue < d.ResidentialTargetLandValue.GetTooLowValue(Level.Level5)) levelUp.landValueTooLow = true;
            }

            return levelUp;
        }

        public override CommercialLevelUp OnCalculateCommercialLevelUp(CommercialLevelUp levelUp, int averageWealth, int landValue, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (levelUp.landValueProgress != 0)
            {
                Level targetLevel;

                int target2 = d.CommercialTargetLandValue.GetValue(Level.Level2);
                int target3 = d.CommercialTargetLandValue.GetValue(Level.Level3);

                if (landValue < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.landValueProgress = 1 + (int)(15f * landValue / target2 + 0.49f);
                }
                else if (landValue < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target2) / (target3 - target2) + 0.49f);
                }
                else
                {
                    targetLevel = Level.Level5;
                    levelUp.landValueProgress = 1;
                }

                if (targetLevel < currentLevel)
                {
                    levelUp.landValueProgress = 1;
                }
                else if (targetLevel > currentLevel)
                {
                    levelUp.landValueProgress = 15;
                }

                if (targetLevel < levelUp.targetLevel)
                {
                    levelUp.targetLevel = targetLevel;
                }
            }

            levelUp.landValueTooLow = false;
            if (currentLevel == Level.Level2)
            {
                if (landValue < d.CommercialTargetLandValue.GetTooLowValue(Level.Level2)) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (landValue < d.CommercialTargetLandValue.GetTooLowValue(Level.Level3)) levelUp.landValueTooLow = true;
            }

            return levelUp;
        }

        public override IndustrialLevelUp OnCalculateIndustrialLevelUp(IndustrialLevelUp levelUp, int averageEducation, int serviceScore, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (levelUp.serviceProgress != 0)
            {
                Level targetLevel;

                int target2 = d.IndustrialTargetScore.GetValue(Level.Level2);
                int target3 = d.IndustrialTargetScore.GetValue(Level.Level3);

                if (serviceScore < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.serviceProgress = 1 + (int)(15f * serviceScore / target2 + 0.49f);
                }
                else if (serviceScore < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.serviceProgress = 1 + (int)(15f * (serviceScore - target2) / (target3 - target2) + 0.49f);
                }
                else
                {
                    targetLevel = Level.Level5;
                    levelUp.serviceProgress = 1;
                }

                if (targetLevel < currentLevel)
                {
                    levelUp.serviceProgress = 1;
                }
                else if (targetLevel > currentLevel)
                {
                    levelUp.serviceProgress = 15;
                }

                if (targetLevel < levelUp.targetLevel)
                {
                    levelUp.targetLevel = targetLevel;
                }
            }

            levelUp.tooFewServices = false;
            if (currentLevel == Level.Level2)
            {
                if (serviceScore < d.IndustrialTargetScore.GetTooLowValue(Level.Level2)) levelUp.tooFewServices = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (serviceScore < d.IndustrialTargetScore.GetTooLowValue(Level.Level3)) levelUp.tooFewServices = true;
            }

            return levelUp;
        }

        public override OfficeLevelUp OnCalculateOfficeLevelUp(OfficeLevelUp levelUp, int averageEducation, int serviceScore, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (levelUp.serviceProgress != 0)
            {
                Level targetLevel;

                int target2 = d.OfficeTargetScore.GetValue(Level.Level2);
                int target3 = d.OfficeTargetScore.GetValue(Level.Level3);

                if (serviceScore < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.serviceProgress = 1 + (int)(15f * serviceScore / target2 + 0.49f);
                }
                else if (serviceScore < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.serviceProgress = 1 + (int)(15f * (serviceScore - target2) / (target3 - target2) + 0.49f);
                }
                else
                {
                    targetLevel = Level.Level5;
                    levelUp.serviceProgress = 1;
                }

                if (targetLevel < currentLevel)
                {
                    levelUp.serviceProgress = 1;
                }
                else if (targetLevel > currentLevel)
                {
                    levelUp.serviceProgress = 15;
                }

                if (targetLevel < levelUp.targetLevel)
                {
                    levelUp.targetLevel = targetLevel;
                }
            }

            levelUp.tooFewServices = false;
            if (currentLevel == Level.Level2)
            {
                if (serviceScore < d.OfficeTargetScore.GetTooLowValue(Level.Level2)) levelUp.tooFewServices = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (serviceScore < d.OfficeTargetScore.GetTooLowValue(Level.Level3)) levelUp.tooFewServices = true;
            }

            return levelUp;
        }
    }
}
