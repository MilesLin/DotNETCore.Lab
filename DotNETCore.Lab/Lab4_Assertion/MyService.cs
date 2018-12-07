using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DotNETCore.Lab.Lab4_Assertion
{
    public class MyService
    {
        public bool IsValidBankName(string bankName)
        {
            return bankName == "CUB";
        }

        public int GetARandomSerialNumber(int maxValue = 999)
        {
            var r = new Random();
            return r.Next(maxValue);
        }

        public string MessageGen(string name)
        {
            return $"Hi {name}, thank you for your purchase...";
        }

        public ActionResult GetOrders()
        {
            var orders = new List<Order>
            {
                new Order { Id = 1, ItemName = "Shoes", Price= 2000 },
                new Order { Id = 2, ItemName = "Bag", Price= 500 },
                new Order { Id = 3, ItemName = "Wallet", Price= 180 }
            };

            return new OkObjectResult(orders);
        }

        public bool IsValidPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("請傳入非 Null 字串");
            }

            // 至少有一個數字
            // 至少有一個小寫英文字母
            // 至少有一個大寫英文字母
            // 字串長度在 6 ~12 個字母之間
            string pattern = @"^(?=.*\d)(?=.*[a-zA-Z]).{6,12}$";
            var r = new Regex(pattern);

            return r.IsMatch(password);
        }
    }
}