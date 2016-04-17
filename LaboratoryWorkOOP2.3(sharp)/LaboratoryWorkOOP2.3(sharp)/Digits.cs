﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWorkOOP2._3_sharp_
{
    class Digits:Strings
    {
        List<int> allDigits;

        public Digits(int[] arr)
        {
            allDigits = new List<int>();
            foreach (var elem in arr)
                allDigits.Add(elem);
        }

        public override void MakeSmallString()
        {
            allDigits.Remove(allDigits[allDigits.Count - 1]);
        }

        public override void Show()
        {
            foreach (var elem in allDigits)
                Console.Write(elem);
            Console.WriteLine();
        }

        public override int StringLengnth()
        {
            return allDigits.Count;
        }

        public virtual void RemoveFromOddPosition()
        {
            for (int i = 0; i < allDigits.Count; i++)
                if (i % 2 == 1)
                    allDigits.Remove(allDigits[i]);
            Show();
        }
    }
}
