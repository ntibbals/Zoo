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
        [Fact]
        public void OrcaEat()
        {
            /// Test that orca eating exhibits proper behavior
            Orca orca = new Orca();
            string testEating = "Me eat food.";
            Assert.Equal(testEating, orca.Eating());
        }

        [Fact]
        public void OrcaSwims()
        {
            /// Test that orca swimming exhibits proper behavior
            Orca orca = new Orca();
            Assert.True(orca.Swim());
        }

        [Fact]
        public void WhaleBirthing()
        {
            /// Test that Whale birthing exhibits proper behavior
            BlueWhale whale = new BlueWhale();
            Assert.True(whale.Birthing());
        }
        [Fact]
        public void WhaleSleeping()
        {
            /// Test that Whale sleeping  exhibits proper behavior
            BlueWhale whale = new BlueWhale();
            string testSleep = "Me sleep.";
            Assert.Equal(testSleep, whale.Sleeping());
        }
        [Fact]
        public void TurtleEggs()
        {
            /// Test that turtle laying eggs exhibits proper behavior
            SpottedTurtle turtle = new SpottedTurtle();
            Assert.True(turtle.Lays_Eggs());
        }
        [Fact]
        public void TurtleEating()
        {
            /// Test that turtle eating exhibits proper behavior
            SpottedTurtle turtle = new SpottedTurtle();
            string testEating = "Me eat food.";
            Assert.Equal(testEating, turtle.Eating());
        }

        [Fact]
        public void GeckoSleepings()
        {
            /// Test that gecko sleeping exhibits proper behavior
            LeopardGecko gecko = new LeopardGecko();
            string testSleep = "Me sleep.";
            Assert.Equal(testSleep, gecko.Sleeping());
        }

        [Fact]
        public void GeckoMigrating()
        {
            /// Test that gecko Migrating exhibits proper behavior
            LeopardGecko gecko = new LeopardGecko();
            Assert.False(gecko.Migrates());
        }

        [Fact]
        public void SalamanderRibbit()
        {
            /// Test that slamander does not ribbit exhibits proper behavior
            CaveSalamander salamander = new CaveSalamander();
            string testRibbit = "Slither, slither";
            Assert.Equal(testRibbit, salamander.Ribbit());
        }

        [Fact]
        public void SalamanderEating()
        {
            /// Test that Salamander eating exhibits proper behavior
            CaveSalamander salamander = new CaveSalamander();
            string testEating = "Me eat food.";
            Assert.Equal(testEating, salamander.Eating());
        }

        [Fact]
        public void FrogSleeping()
        {
            /// Test that Frog sleeping exhibits proper behavior
            BlueMntTreeFrong frog = new BlueMntTreeFrong();
            string testSleep = "Me sleep.";
            Assert.Equal(testSleep, frog.Sleeping());
        }
        [Fact]
        public void FrogEggs()
        {
            /// Test that Frog laying eggs exhibits proper behavior
            BlueMntTreeFrong frog = new BlueMntTreeFrong();
            Assert.True(frog.LaysEggs());
        }
    }
}
