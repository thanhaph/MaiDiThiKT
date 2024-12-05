using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBai1
{
    [TestFixture]
    public class SinhVienTest
    {
        private SinhVienServices _sv = new SinhVienServices();
        [Test]
        [TestCase("Sv1","haha",18,9.5f,2,"ptpm")]
        [TestCase("Sv2","haha",18,9.5f,2,"ptpm")]
        [TestCase("SV3","haha",18,9.5f,2,"ptpm")]
        [TestCase("Sv4","haha",18,9.5f,2,"ptpm")]
        [TestCase("Sv5","haha",18,9.5f,2,"ptpm")]
        public void TestAdd (string MaSV, string ten, int tuoi, float dtb, int hocki, string chuyennganh)
        {
            var sv = new SinhVien(MaSV, ten, tuoi, dtb, hocki, chuyennganh);
             _sv.Add(sv);
            Assert.Pass();

        }
        [Test]
        [TestCase("", "haha", 18, 9.5f, 2, "ptpm")]
        [TestCase("", "", 0, 0, 0, "0")]
        [TestCase("sv9", "haha", 17, 9.5f, 2, "ptpm")]
        [TestCase("sv10", "haha", 0, 9.5f, 2, "ptpm")]
        [TestCase("sv11", "haha", 16, 9.5f, 2, "ptpm")]
        [TestCase("sv11", "haha", 16, 9.5f, 2, "ptpm")]

        public void TestAdd1(string MaSV, string ten, int tuoi, float dtb, int hocki, string chuyennganh)
        {
            var sv = new SinhVien(MaSV, ten, tuoi, dtb, hocki, chuyennganh);
            Assert.Throws<Exception>(() => _sv.Add(sv));
        }

    }
}
