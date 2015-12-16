namespace Pantry.Business.Engines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class ImperialToMetricCalculator
    {
        enum Accuracy
        {
            Teaspoon,
            Tablespoon,
            Cup
        }
        
        decimal teaspoonToMlRatio = .202884M;

        decimal teaspoonToQuarterCup = 12M;

        decimal teaspoonToTablespoon = 3M;

        decimal teaspoonToQuarterTeaspoon = .25M;
        
        public decimal MlToTeaspoons(decimal amountInMl)
        {
            decimal amountInTsps = amountInMl * teaspoonToMlRatio;

            return amountInTsps;
        }

        //public string TeaspoonsToImperial(Accuracy accuracy)
        //{
        //    switch (accuracy) { 
        //        case Accuracy.Teaspoon:
        //            break;
        //        case Accuracy.Tablespoon:
        //            break;
        //        case Accuracy.Cup:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public string ToCupString(decimal amountInTsps)
        //{
        //    if (amountInTsps / 48M < 1M)
        //    {
 
        //    }
        //}

        //public string ToTeaspoonString(decimal amountInTsps)
        //{ 
        //}

        //public string ToTablespoonString(decimal amountInTsps)
        //{ 
        //}

        
    }
}
