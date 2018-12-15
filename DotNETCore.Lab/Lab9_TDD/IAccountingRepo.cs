using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab9_TDD
{
    public interface IAccountingRepo
    {
        /// <summary>
        /// 取得薪水
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        decimal GetSalary(int id);
    }
}
