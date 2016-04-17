using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWorkOOP2._3_sharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Symbols s = new Symbols("sdgdsggavgdgsavgva");
            s.Show();
            s.RemoveFromOddPosition();
            s.MakeSmallString();
            s.Show();

            int[] arr = { 2, 5, 12, 53, 532, 32, 134, };
            Digits d = new Digits(arr);
            d.Show();
            d.RemoveFromOddPosition();
            d.MakeSmallString();
            d.Show();
        }
    }
}
