using ICities;

namespace DifficultyTuningMod
{
    public class LevelUp : LevelUpExtensionBase
    {
        public override ResidentialLevelUp OnCalculateResidentialLevelUp(ResidentialLevelUp levelUp, int averageEducation, int landValue, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            if (levelUp.landValueProgress != 0)
            {
                Level targetLevel;

                int target2 = DifficultyOptions.ResidentialTargetLandValueLevel2;
                int target3 = DifficultyOptions.ResidentialTargetLandValueLevel3;
                int target4 = DifficultyOptions.ResidentialTargetLandValueLevel4;
                int target5 = DifficultyOptions.ResidentialTargetLandValueLevel5;

                if (landValue < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.landValueProgress = 1 + (int)(15f * landValue / target2 + 0.49);
                }
                else if (landValue < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target2) / (target3 - target2) + 0.49);
                }
                else if (landValue < target4)
                {
                    targetLevel = Level.Level3;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target3) / (target4 - target3) + 0.49);
                }
                else if (landValue < target5)
                {
                    targetLevel = Level.Level4;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target4) / (target5 - target4) + 0.49);
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
                if (landValue < DifficultyOptions.ResidentialTooLowLandValueLevel2) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (landValue < DifficultyOptions.ResidentialTooLowLandValueLevel3) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level4)
            {
                if (landValue < DifficultyOptions.ResidentialTooLowLandValueLevel4) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level5)
            {
                if (landValue < DifficultyOptions.ResidentialTooLowLandValueLevel5) levelUp.landValueTooLow = true;
            }

            return levelUp;
        }

        public override CommercialLevelUp OnCalculateCommercialLevelUp(CommercialLevelUp levelUp, int averageWealth, int landValue, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            if (levelUp.landValueProgress != 0)
            {
                Level targetLevel;

                int target2 = DifficultyOptions.CommercialTargetLandValueLevel2;
                int target3 = DifficultyOptions.CommercialTargetLandValueLevel3;

                if (landValue < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.landValueProgress = 1 + (int)(15f * landValue / target2 + 0.49);
                }
                else if (landValue < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.landValueProgress = 1 + (int)(15f * (landValue - target2) / (target3 - target2) + 0.49);
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
                if (landValue < DifficultyOptions.CommercialTooLowLandValueLevel2) levelUp.landValueTooLow = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (landValue < DifficultyOptions.CommercialTooLowLandValueLevel3) levelUp.landValueTooLow = true;
            }

            return levelUp;
        }

        public override IndustrialLevelUp OnCalculateIndustrialLevelUp(IndustrialLevelUp levelUp, int averageEducation, int serviceScore, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            if (levelUp.serviceProgress != 0)
            {
                Level targetLevel;

                int target2 = DifficultyOptions.IndustrialTargetServiceLevel2;
                int target3 = DifficultyOptions.IndustrialTargetServiceLevel3;

                if (serviceScore < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.serviceProgress = 1 + (int)(15f * serviceScore / target2 + 0.49);
                }
                else if (serviceScore < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.serviceProgress = 1 + (int)(15f * (serviceScore - target2) / (target3 - target2) + 0.49);
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
                if (serviceScore < DifficultyOptions.IndustrialTooFewServiceLevel2) levelUp.tooFewServices = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (serviceScore < DifficultyOptions.IndustrialTooFewServiceLevel3) levelUp.tooFewServices = true;
            }

            return levelUp;
        }

        public override OfficeLevelUp OnCalculateOfficeLevelUp(OfficeLevelUp levelUp, int averageEducation, int serviceScore, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            if (levelUp.serviceProgress != 0)
            {
                Level targetLevel;

                int target2 = DifficultyOptions.OfficeTargetServiceLevel2;
                int target3 = DifficultyOptions.OfficeTargetServiceLevel3;

                if (serviceScore < target2)
                {
                    targetLevel = Level.Level1;
                    levelUp.serviceProgress = 1 + (int)(15f * serviceScore / target2 + 0.49);
                }
                else if (serviceScore < target3)
                {
                    targetLevel = Level.Level2;
                    levelUp.serviceProgress = 1 + (int)(15f * (serviceScore - target2) / (target3 - target2) + 0.49);
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
                if (serviceScore < DifficultyOptions.OfficeTooFewServiceLevel2) levelUp.tooFewServices = true;
            }
            else if (currentLevel == Level.Level3)
            {
                if (serviceScore < DifficultyOptions.OfficeTooFewServiceLevel3) levelUp.tooFewServices = true;
            }

            return levelUp;
        }
    }
}
