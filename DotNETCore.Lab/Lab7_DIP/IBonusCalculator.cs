using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab7_DIP
{
    public interface IBonusCalculator
    {
        decimal CalculateBonus(int sells);
    }
}
