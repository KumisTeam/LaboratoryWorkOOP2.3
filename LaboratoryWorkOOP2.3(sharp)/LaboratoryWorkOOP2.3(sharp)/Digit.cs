using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWorkOOP2._3_sharp_
{
    class Digit : Row
    {
        private List<int> digits;

        public Digit(string usrDigits)
        {
            digits = new List<int>();
            char[] tmpArr = usrDigits.ToCharArray();
            foreach (var elem in tmpArr)
                if (char.IsDigit(elem))
                    digits.Add(Convert.ToInt32(elem));
        }

        public override void DeleteSmth()
        {
            for (int i = 0; i < digits.Count; i++)
                digits.Remove(5);
            Show();
        }

        public override int GetSize()
        {
            return digits.Count;
        }

        public override void Show()
        {
            foreach (var elem in digits)
                Console.Write(elem);
            Console.WriteLine();
        }
    }
}
