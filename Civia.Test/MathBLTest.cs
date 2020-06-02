using Civia.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Civia.Test
{
    public class MathBLTest
    {

        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void TestSum()
        {
            var mathBL = new MathBL();
            int result = mathBL.Sum(2, 3);
            Assert.IsTrue(result == 5);
        }
    }
}
