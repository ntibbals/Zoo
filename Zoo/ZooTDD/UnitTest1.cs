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
            /// Test that tiger birthing exhibits proper behavior
            BengalTiger tiger = new BengalTiger();
            Assert.True(tiger.Birthing());
        }


        [Fact]
        public void LionRoaming()
        {
            /// Test that lion roamingexhibits proper behavior
            Lion lion = new Lion();
            string testRoam = "Just roaming around....";
            Assert.Equal(testRoam, lion.Roam());
        }

        [Fact]
        public void LionSleeping()
        {
            /// Test that lion sleeping exhibits proper behavior
            Lion lion = new Lion();
            string testSleep = "Me sleep.";
            Assert.Equal(testSleep, lion.Sleeping());
        }
    }
}
