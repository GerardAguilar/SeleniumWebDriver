using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework2;

namespace QtpTests
{
    [TestClass]
    public class TestBase
    {
        [TestInitialize]
        public void Initialize() {
            Browser.Initialize();
        }

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestCleanup]
        public void Cleanup() {//doesn't clean up all that well, ie: when a new tab is opened, only that tab is closed
            Browser.Close();
        }
    }
}
