using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DotNETCore.Lab.UnitTests.Lab6_SharedContext
{
    [CollectionDefinition(CollecitonKey.DataCollection)]
    public class DataCollection : ICollectionFixture<DataFixture>
    {

    }

    public class CollecitonKey
    {
        public const string DataCollection = "Database collection";
    }
    
}
