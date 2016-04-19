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
            Digit d = new Digit("311113335556672");
            d.Show();
            d.DeleteSmth();

            Letter l = new Letter("asdsaaaahhshhhh");
            l.Show();
            l.DeleteSmth();
        }
    }
}
