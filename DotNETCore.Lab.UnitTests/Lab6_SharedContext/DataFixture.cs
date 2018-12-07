using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.UnitTests.Lab6_SharedContext
{
    public class DataFixture : IDisposable
    {
        public string Db { get; private set; }

        public DataFixture()
        {
            // 類別內的測試執行前會執行
            Db = "SQL Server";
        }

        public void Dispose()
        {
            // 類別內的測試執行完後會執行
            Db = null;
        }
    }
}
