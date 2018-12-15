using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab9_TDD
{
    public class YearBonusAPI
    {
        private IEmployeeRepo _employee;
        private IAccountingRepo _account;

        public YearBonusAPI(IEmployeeRepo employee, IAccountingRepo account)
        {
            _employee = employee;
            _account = account;
        }

        public BonusVM GetYearsBonus(int id)
        {
            var employee = this._employee.GetEmployeeInfo(id);
            var salary = this._account.GetSalary(id);
            decimal bonus = salary;
            if (employee.Department == Department.管理部)
            {
                bonus = salary * 1.5m;
            }

            if (employee.Position == Position.職等一)
            {
                bonus *= 1.1m;
            }
            else
            {
                bonus *= 1.15m;
            }

            return new BonusVM()
            {
                Id = employee.Id,
                Name = employee.Name,
                YearBonus = bonus
            };

        }
    }
}
