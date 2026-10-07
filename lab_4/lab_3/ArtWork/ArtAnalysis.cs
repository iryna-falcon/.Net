using lab_4.Interfaces;

namespace lab_4.ArtWork
{
    public class ArtAnalysis
    {
        public static double GetTotalValueBefore1900(List<ArtWork> works)
        {
            double totalValue = 0;

            foreach (var work in works)
            {
                if (work.CreationYear < 1900)
                {
                    totalValue += work.Value;
                }
            }
            return totalValue;
        }

        public static double GetTotalInsuranceCost(List<IInsurable> insurableItems)
        {
            double totalInsurance = 0;
            foreach (var item in insurableItems)
            {
                totalInsurance += item.GetInsuranceCost();
            }
            return totalInsurance;
        }
    }
}