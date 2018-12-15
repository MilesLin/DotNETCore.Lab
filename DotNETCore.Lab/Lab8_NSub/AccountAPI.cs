using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab8_NSub
{
    public class AccountAPI
    {
        private readonly IAccountRepo _accountRepo;
        private readonly ILogger _logger;

        public AccountAPI(
            IAccountRepo accountRepo,
            ILogger logger)
        {
            this._accountRepo = accountRepo;
            this._logger = logger;
        }

        public string CreateANewAccount(string id)
        {
            bool isExistId = this._accountRepo.IsExist(id);
            if (isExistId)
            {
                return "此身分證已建立過帳號";
            }

            try
            {
                this._accountRepo.Create(id);
            }
            catch (Exception e)
            {
                this._logger.Error(e);
                return "系統發生錯誤";
            }

            return "帳號建立完成";
        }
    }
}
