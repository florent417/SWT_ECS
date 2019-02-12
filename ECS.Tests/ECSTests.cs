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
            var uut = new TestECS(28, new TestTempSensor(), new TestHeater());

            Assert.That(uut.RunSelfTest,Is.EqualTo(true));
        }
        /*
        [Test]
        public void TurnOn_ReturnsTrue()
        {
            var uut = new 
        }
        */
    }
}
