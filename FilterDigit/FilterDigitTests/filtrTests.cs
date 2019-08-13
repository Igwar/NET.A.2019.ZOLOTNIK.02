using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterDigit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit.Tests
{
    [TestClass()]
    public class filtrTests
    {
        [TestMethod()]
        public void findnimberTest()
        {
            List<int> a = new List<int>() { 7, 70, 17 };
           
            List<int> b = new List<int>() {1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
          
            Assert.IsTrue(a.SequenceEqual( filtr.findnimber(7, ref b)));
        }
    }
}