using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab8_NSub
{
    public interface IAccountRepo
    {
        bool IsExist(string id);

        void Create(string id);
    }
}
