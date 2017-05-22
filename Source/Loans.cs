using System;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public static class Loans
    {
        private static int[] m_amount_orig = new int[3];
        private static int[] m_length_orig = new int[3];

        public static void SetLoans()
        {
            EconomyManager em = Singleton<EconomyManager>.instance;
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            for (int i = 0; i < 3; i++)
            {
                EconomyManager.Bank bank = em.m_properties.m_banks[i];
                EconomyManager.LoanInfo li = bank.m_loanOffers[0];

                int newAmount = (int)Math.Round(li.m_amount * 0.01f * d.LoanMultiplier.Value);
                int newLength = (int)Math.Round(li.m_length * (1 + 0.01f * d.LoanMultiplier.Value) / 2f); // Halve the effect to prevent too long loan length.
                Helper.ValueChangedMessage(bank.m_bankName, "Loan amount", li.m_amount, newAmount);
                Helper.ValueChangedMessage(bank.m_bankName, "Loan length", li.m_length, newLength);

                m_amount_orig[i] = li.m_amount;
                li.m_amount = newAmount;

                m_length_orig[i] = li.m_length;
                li.m_length = newLength;

                bank.m_loanOffers[0] = li;
                em.m_properties.m_banks[i] = bank;
            }
        }

        public static void ResetLoans()
        {
            EconomyManager em = Singleton<EconomyManager>.instance;

            for (int i = 0; i < 3; i++)
            {
                EconomyManager.Bank bank = em.m_properties.m_banks[i];
                EconomyManager.LoanInfo li = bank.m_loanOffers[0];

                li.m_amount = m_amount_orig[i];

                li.m_length = m_length_orig[i];

                bank.m_loanOffers[0] = li;
                em.m_properties.m_banks[i] = bank;
            }
        }
    }
}
