using System;

namespace hello
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           /*   [1,2,4,5,6,7] => 3 is counted out and goes into the result [3] -> [1,2,0,4,5,6,7]
                [1,2,4,5,7] => 6 is counted out and goes into the result [3,6] -> [1,2,0,4,5,0,7]
                [1,4,5,7] => 2 is counted out and goes into the result [3,6,2] -> [1,0,0,4,5,0,7]
                [1,4,5] => 7 is counted out and goes into the result [3,6,2,7] -> [1,0,0,4,5,0,0]
                [1,4] => 5 is counted out and goes into the result [3,6,2,7,5] -> [1,0,0,4,0,0,0]
                [4] => 1 is counted out and goes into the result [3,6,2,7,5,1] -> [0,0,0,4,0,0,0]
                [] => 4 is counted out and goes into the result [3,6,2,7,5,1,4]-> [0,0,0,0,0,0,0]
            */
           
           
            int[] array = {1, 2, 3, 4, 5, 6, 7};

            int loopingArray = 0;
            int index = 0;
            int count = 0;
            int[] newArray = new int[array.Length];
            while (loopingArray < array.Length)
            {
                if (array[loopingArray] != 0)
                {
                    count++;
                    if (count == 3)
                    {
                        newArray[index] = array[loopingArray];
                        array[loopingArray] = 0;
                        count = 0;
                        index++;
                    }
                    
                    if (loopingArray == array.Length - 1)
                    {
                        count++;
                        loopingArray = 0;
                    }
                }    
                
                loopingArray++;
            }
            
            
            for(int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();
            for(int i = 0; i < newArray.Length; i++)
                Console.Write(newArray[i] + " ");
        }
        
    }
}