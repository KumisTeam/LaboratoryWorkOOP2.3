using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWorkOOP2._3_sharp_
{
    class Symbols : Strings
    {
        List<char> allSymbols;

        public Symbols(string str)
        {
            allSymbols = new List<char>();
            foreach (var elem in str)
                allSymbols.Add(elem);
        }

        public override int StringLengnth()
        {
            return allSymbols.Count;
        }

        public override void MakeSmallString()
        {
            allSymbols.Remove(allSymbols[allSymbols.Count-1]);
        }

        public override void Show()
        {
            foreach (var elem in allSymbols)
                Console.Write(elem);
            Console.WriteLine();
        }

        public virtual void RemoveFromOddPosition()
        {
            for (int i = 0; i < allSymbols.Count; i++)
                if (i % 2 == 1)
                    allSymbols.Remove(allSymbols[i]);
            Show();
        }
    }
}
