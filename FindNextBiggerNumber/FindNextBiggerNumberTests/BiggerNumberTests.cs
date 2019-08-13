using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNextBiggerNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber.Tests
{
    [TestClass()]
    public class BiggerNumberTests
    {
        [TestMethod()]
        public void findnimber12Expected21()
        {
            long a=0;
            Assert.AreEqual(21, BiggerNumber.findnimber(12, out a));
        }
        [TestMethod()]
        public void findnimber513Expected531()
        {
            long a = 0;
            Assert.AreEqual(531, BiggerNumber.findnimber(513, out a));
        }
        [TestMethod()]
        public void findnimber2017Expected2071()
        {
            long a = 0;
            Assert.AreEqual(2071, BiggerNumber.findnimber(2017, out a));
        }
        [TestMethod()]
        public void findnimber414Expected441()
        {
            long a = 0;
            Assert.AreEqual(441, BiggerNumber.findnimber(414, out a));
        }
        [TestMethod()]
        public void findnimber144Expected414()
        {
            long a = 0;
            Assert.AreEqual(414, BiggerNumber.findnimber(144, out a));
        }
        [TestMethod()]
        public void findnimber1234321Expected1241233()
        {
            long a = 0;
            Assert.AreEqual(1241233, BiggerNumber.findnimber(1234321, out a));
        }
        [TestMethod()]
        public void findnimber1234126Expected1234162()
        {
            long a = 0;
            Assert.AreEqual(1234162, BiggerNumber.findnimber(1234126, out a));
        }
        [TestMethod()]
        public void findnimber3456432Expected3462345()
        {
            long a = 0;
            Assert.AreEqual(3462345, BiggerNumber.findnimber(3456432, out a));
        }
        [TestMethod()]
        public void findnimber10Expectedmin1()
        {
            long a = 0;
            Assert.AreEqual(-1, BiggerNumber.findnimber(10, out a));
        }
        [TestMethod()]
        public void findnimber20Expectedmin1()
        {
            long a = 0;
            Assert.AreEqual(-1, BiggerNumber.findnimber(20, out a));
        }
    }
}