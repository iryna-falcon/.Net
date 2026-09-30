using System;
using System.Collections.Generic;

namespace lab_3
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
    }
}