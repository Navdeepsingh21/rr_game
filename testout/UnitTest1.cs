using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rr_game;// calling the main program

namespace testout
{

    [TestClass]
    public class UnitTest1
    //defining and object in class "game"
    {
        game testing = new game();

        [TestMethod]
        public void TestMethod1()

        {
            //act- need to provide some data to get and output
            var act = testing.chngebulet(4);
            //assert - need to check the output with the expected data is wheather correct or not
            Assert.AreEqual(expected: 5, act);
        }

        [TestMethod]
        public void testmethod2()
        {
            //act- need to provide some data to get and output
            var act = testing.chngebulet(4);
            //assert - need to check the output with the expected data is wheather correct or not
            Assert.AreNotEqual(notExpected: 4, act);

        }
    }
}
