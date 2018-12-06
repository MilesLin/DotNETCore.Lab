using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab3_Assertion
{
    public class ActionResult
    {
    }


    public class OkObjectResult : ActionResult
    {
        public object Value { get; private set; }

        public OkObjectResult(object value)
        {
            this.Value = value;
        }
    }
}
