using System;
using System.Media;
using System.Runtime.Versioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Bulletgametest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SoundPlayer sndplrPlayer = new SoundPlayer(@"gunfire.wav");
            Assert.IsTrue(sndplrPlayer != null);
        }


        [TestMethod]
        public void TestMethod2()
        {
         char[] bulletArray = new char[6];

        Assert.IsTrue(bulletArray != null);
        }

        [TestMethod]
        public void TestMethod3()
        {
          int rand;
        Assert.IsTrue(new Random() != null);
        }
    }
}
