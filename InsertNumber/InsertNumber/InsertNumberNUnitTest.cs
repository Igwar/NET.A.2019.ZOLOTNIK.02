using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace InsertNumber
{
    [TestFixture]
    class InsertNumberNUnitTest
    {
        [Test]
        public void Insert15in15from0to0()
        {
            Assert.AreEqual(15, InsertNum.Insert(15, 15, 0, 0));
        }
        [Test]
        public void Insert15in8from0to0()
        {
            Assert.AreEqual(9, InsertNum.Insert(8, 15, 0, 0));
        }
        [Test]
        public void Insert15in8from3to8()
        {
            Assert.AreEqual(120, InsertNum.Insert(8, 15, 3, 8));
        }
    }
}
