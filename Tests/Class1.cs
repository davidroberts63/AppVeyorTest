﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class Class1
    {
        [Fact]
        public void DoesAdd()
        {
            Assert.Equal(2 + 2, 4);
        }
    }
}
