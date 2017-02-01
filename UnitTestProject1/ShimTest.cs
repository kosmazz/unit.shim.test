using System;
using System.Runtime.Remoting.Messaging;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using shim.test;
using shim.test.Fakes;

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
                ShimShimClass x = new ShimShimClass { NowGet = () => { return DateTime.Now; }};

                var a = new TargetClass();

                if (a.DoSomething().Year != 2017)
                {
                    Assert.Fail();
                }
            }
        }
    }
}
