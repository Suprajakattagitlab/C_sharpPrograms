using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class Program
    {
        public static void Main(String[] args)
        {
            SubsetProgram s = new SubsetProgram();
            if (s.CheckSubsetofArray())
                Console.WriteLine("Array 2 is the subset of the 1st array");
            else
                Console.WriteLine("Array 2 is not the subset of the 1st Array");
            
        }
    }
}
