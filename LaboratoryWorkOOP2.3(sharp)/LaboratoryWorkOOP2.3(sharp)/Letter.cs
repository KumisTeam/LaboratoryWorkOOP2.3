using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWorkOOP2._3_sharp_
{
    class Letter : Row
    {
        private List<char> letters;

        public Letter(string userLetters)
        {
            letters = new List<char>();
            char[] tmpArr = userLetters.ToCharArray();
            foreach (var elem in tmpArr)
                if (char.IsLetter(elem))
                    letters.Add(elem);
        }

        public override void DeleteSmth()
        {
            for (int i = 0; i < letters.Count; i++)
                letters.Remove('a');
            Show();
        }

        public override int GetSize()
        {
            return letters.Count;
        }

        public override void Show()
        {
            foreach (var elem in letters)
                Console.Write(elem);
            Console.WriteLine();
        }
    }
}
