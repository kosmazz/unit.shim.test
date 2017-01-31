using System;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using shim.test;

namespace UnitTestProject1
{
    [TestClass]
    public class ShimTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            

            using (ShimsContext.Create())
            {
                var a = new TargetClass();

                if (a.DoSomething().Year != 2017)
                {
                    Assert.Fail();
                }
            }
        }
    }
}
