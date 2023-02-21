using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class SubsetProgram
    {
        List<int> list1 = new List<int>();
       List<int> list2 = new List<int>();
        public bool CheckSubsetofArray()
        {
            Console.WriteLine("input the  first array");
            var input =(Console.ReadLine());
            string[] s = input.Split(" ");
            //list1=new List<int> {r};
            int intout;
            foreach(string i in s)
            {
                if (Int32.TryParse(i, out intout))
                    list1.Add(intout);
            }
            Console.WriteLine("input the  second array");
            var input1 = Console.ReadLine();
            string[] s1 = input1.Split(" ");
            //list1=new List<int> {r};
            int intout1;
            foreach (string i in s1)
            {
                if (Int32.TryParse(i, out intout1))
                    list2.Add(intout1);
            }
            if(list1.Count > list2.Count)
            {
                return false;
            }
           // int count = 0;
            for(int i = 0; i <list2.Count; i++)
            {
                int count = 0;
                int start = list1[0];
                int k = i;
                int start1 = list2[k];
                if (start1 == start)
                {
                    
                    for(int j = 1; j < list1.Count; j++)
                    {
                        k += 1;
                        if (k>=list2.Count || list2[k] != list1[j])
                        {
                            count = 1;
                            break;
                        }
                        

                    }
                    if(count==0)
                    {
                        return true;
                    }



                }
                
               

                        
                    
                
            }
            return false;

        }

    }
}

