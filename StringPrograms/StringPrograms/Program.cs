using System;
namespace StringPrograms
{
    public class Program
    {
        
        ///Count the occurrence of each character in a string.
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the string input");
            string s=Console.ReadLine();
            Dictionary<char,int> d=new Dictionary<char,int>();
            for(int i=0;i<s.Length;i++)
            {
                
                if (d.ContainsKey(s[i]))
                {
                    d[s[i]]++;
                }
                else
                {
                    d[s[i]] = 1;
                }

                
            }
            foreach(char key in d.Keys)
            {
                Console.WriteLine($"{key}:{d[key]}");
            }
        }

    }
}
