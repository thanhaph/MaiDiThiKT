using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBai1
{
    [TestFixture]
    public class TestTrungBinhCong
    {
        private Bai1 _b1 =new Bai1();
        [Test]
        [TestCase(new int[] {},0)]
        [TestCase(new int[] {3,3,3,3}, 3)]
        public void TBCTest (int[] a, double b)
        {
            Assert.Throws<ArgumentException>(() => _b1.TrungBinhCong(a));
        }
        [Test]
        [TestCase(new int[] { 1,2,3},2)]
        [TestCase(new int[] { 3,3,3},3)]
        [TestCase(new int[] { 7,2,3},4)]
        [TestCase(new int[] { 10,2,3},5)]
        public void TBCtestok (int[] a, double b)
        {
            var res = _b1.TrungBinhCong(a);
            Assert.AreEqual(b, res);
        }

    }
}
