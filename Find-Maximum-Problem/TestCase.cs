using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Problem
{
    class TestCase
    {
        public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void ThreeIntegersReturnMaximum()
            {
                int get = 9;
                int num1 = 4,
                    num2 = 9,
                    num3 = 6;
                Program findMaximum = new Program();
                int maximum = findMaximum.IntegerMaximum(num1, num2, num3);
                Assert.AreEqual(get, maximum);
            }
        }
    }
}

