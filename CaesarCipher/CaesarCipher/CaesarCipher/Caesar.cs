using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class Caesar
    {
        public void run()
        {
            Console.WriteLine("Enter the string to encrypt");
      

            string input = Console.ReadLine().Trim();
            input= input.ToUpper();
            if(string.IsNullOrEmpty(input))
            {
                return;
            }
            
            Console.WriteLine("Enter the encryption value");
            int i = int.Parse(Console.ReadLine());
            char []s = input.ToArray();
         
           // int shift = 0;
            for (int j = 0; j < s.Length; j++)
            {
                // Console.WriteLine(data1['A']);
                // int shift = (data1[s[j]] + i) % 26;
                //  Console.WriteLine(data[shift]);
                //Console.WriteLine($"{data[shift]}\t");
                //  
                var r=(s[j] - 65 + i) % 26;
                Console.Write(Convert.ToChar(r + 65));

            }
            

        }
       
    }
}
