using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab7_DIP
{
    public class BonusAPI
    {
        IBonusCalculator _cal;
        public BonusAPI(IBonusCalculator cal)
        {
            _cal = cal;
        }

        public decimal GetBonus(int sells)
        {
            return _cal.CalculateBonus(sells);
        }
    }
}
