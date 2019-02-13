using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

// Not sure about the namespaces in this and the other test classes
// But i am pretty sure that the test classes need to be in the test application.
namespace ECS.Tests
{
    [TestClass]
    public class ECSTests
    {
        [Test]
        public void RunSelfTest_HeaterAndTempSensor_ReturnsTrue()
        {
            var uut = new ECS(28, new TestTempSensor(), new TestHeater());

            Assert.That(uut.RunSelfTest,Is.EqualTo(true));
        }
        
        [TestCase(28)]
        [TestCase(-12)]
        public void GetThreshold_Test(int thr)
        {
            var uut = new ECS(thr, new TestTempSensor(), new TestHeater());

            Assert.That(uut.GetThreshold(), Is.EqualTo(thr));
        }

        [TestCase(28)]
        [TestCase(-12)]
        public void SetThreshold_Test(int thr)
        {
            var uut = new ECS(35, new TestTempSensor(), new TestHeater());
            uut.SetThreshold(thr);
            Assert.That(uut.GetThreshold(), Is.EqualTo(thr));
        }


    }
}
