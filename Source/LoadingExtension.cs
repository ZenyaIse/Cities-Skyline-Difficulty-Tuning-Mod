using System;
using ICities;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            EconomyManager em = Singleton<EconomyManager>.instance;
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (mode == LoadMode.NewGame)
            {
                int moneyToAdd = (d.InitialMoney.Value - 70) * 100000;
                em.AddResource(EconomyManager.Resource.LoanAmount, moneyToAdd, ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            }

            if (mode == LoadMode.NewGame || mode == LoadMode.LoadGame)
            {
                for (int i = 0; i < 3; i++)
                {
                    EconomyManager.Bank bank = em.m_properties.m_banks[i];
                    EconomyManager.LoanInfo li = bank.m_loanOffers[0];

                    int newAmount = (int)Math.Round(li.m_amount * 0.01f * d.LoanMultiplier.Value);
                    int newLength = (int)Math.Round(li.m_length * (1 + 0.01f * d.LoanMultiplier.Value) / 2f); // Halve the effect to prevent too long loan length.
                    Helper.ValueChangedMessage(bank.m_bankName, "Loan amount", li.m_amount, newAmount);
                    Helper.ValueChangedMessage(bank.m_bankName, "Loan length", li.m_length, newLength);
                    li.m_amount = newAmount;
                    li.m_length = newLength;

                    bank.m_loanOffers[0] = li;
                    em.m_properties.m_banks[i] = bank;
                }
            }

            Achievements.Update();

            PrefabsManager.UpdatePrefabs(false);
            NetManager.UpdateSlopes(false);
        }
    }
}
