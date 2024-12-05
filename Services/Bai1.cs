using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Bai1
    {
        public double Thuong(object a, object b)
        {
            if (!(a is int) && !(b is int))
            {
                throw new ArgumentException(" a, b phai la so nguyen");
            }
            if ((int)b == 0)
            {
                throw new ArgumentException(" khong the chi cho 0 ");
            }
            return (int)a / (int)b;
        }
        public double TrungBinhCong(int[] arr)
        {
            if (arr.Length != 3)
            {
                throw new ArgumentException(" phai du 3 dau diem");
            }
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("khong duoc de trong");
            }
            return arr.Average();

        }
    }
}
