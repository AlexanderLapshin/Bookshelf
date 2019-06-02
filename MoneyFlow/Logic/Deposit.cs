using System;

namespace MoneyFlow.Logic
{
    public static class Deposit
    {
        public static double getDepositValue(int months, double percents, int sum, int repeats, bool percentsOnDeposit)
        {
            double percent = percents / 12;
            double profit = 0;
            double newSum = sum;

            repeats++; // One repeat is 100%;
            if (percentsOnDeposit)
            {
                for (int i = 0; i < repeats; i++)
                {
                    for (int j = 0; j < months; j++)
                    {
                        newSum += newSum / 100 * percent;
                    }
                }

                return Math.Round(newSum);
            }
            else
            {
                for (int i = 0; i < repeats; i++)
                {
                    for (int j = 0; j < months; j++)
                    {
                        profit += sum / 100 * percent;
                    }
                }

                return Math.Round(sum + profit);
            }
        }
    }
}
