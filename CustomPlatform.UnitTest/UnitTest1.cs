using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xamarin.Forms;

namespace CustomPlatform.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestCleanup]
        public void CleanUp()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
            
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
