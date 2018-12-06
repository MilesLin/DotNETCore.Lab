using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab2_LoginCounter
{
    public class Counter
    {
        private int _count = 0;

        public int CurrentCount
        {
            get
            {
                return _count;
            }
        }

        public void Add(int i)
        {
            _count += i;
        }
    }
}
