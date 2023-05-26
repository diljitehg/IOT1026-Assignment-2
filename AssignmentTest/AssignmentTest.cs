using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void OpenClosedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }

        [TestMethod]
        public void OpenOpenTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }

        [TestMethod]
        public void CloseOpenTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void CloseClosedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void CloseLockedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void LockClosedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void LockLockedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void LockOpenTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }

        [TestMethod]
        public void UnlockClosedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void UnlockLockedTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void UnlockOpenTest()
        {
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());
        }
    }
}
