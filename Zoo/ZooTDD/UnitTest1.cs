using System;
using Xunit;
using Zoo.CLasses;

namespace ZooTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TigerEat()
        {
            /// Test that tiger eating exhibits proper behavior
            BengalTiger tiger = new BengalTiger();
            string testEating = "Me eat food.";
            Assert.Equal(testEating, tiger.Eating());
        }

        [Fact]
        public void TigerBirthing()
        {
            /// Test that tiger eating exhibits proper behavior
            BengalTiger tiger = new BengalTiger();
            Assert.True(tiger.Birthing());
        }
    }
}
