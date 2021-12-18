using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_FizzBuzz
{
    public class FizzBuzzListConsoleWriter
    {
        public void WriteList(List<string> strings)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string s in strings)
            {
                stringBuilder.Append(s + ",");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
