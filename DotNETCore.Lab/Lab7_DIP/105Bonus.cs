using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab7_DIP
{
    public class _105Bonus : IBonusCalculator
    {
        public decimal CalculateBonus(int sells)
        {
            if (sells > 5)
            {
                return 5000;
            }else if(sells > 20)
            {
                return 10000;
            }
            else
            {
                return 0;
            }
        }
    }
}
