using Services;

namespace TestBai1
{
    [TestFixture]
    public class Tests
    {
      private Bai1 _b1 = new Bai1();

        [Test]
        [TestCase(0,1,0)]
        [TestCase(1,1,1)]
        [TestCase(2,2,1)]
        public void ThuongTest( object a, object b, int c)
        {
            var res = _b1.Thuong(a,b);
            Assert.AreEqual(c, res);
        }
        [Test]
        [TestCase(1,0,0)]
        [TestCase(0,0,0)]
        [TestCase("abc", "cdc", 0)]
        public void Thuongtest2(object a, object b, int c)
        {
            Assert.Throws<ArgumentException>(() => _b1.Thuong(a, b));
        }
       
       
        
    }
}