using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_FizzBuzz
{
    public class FizzBuzzListGenerator
    {
        public List<string> Run()
        {
            List<string> generatedList = new List<string>();

            List<int> collectionOfNumbers = Enumerable.Range(1, 100).ToList();

            foreach (int i in collectionOfNumbers)
            {
                generatedList.Add(FizzBuzz.CaluclateFizzBuzz(i));
            }
            return generatedList;
        }        
    }
}
