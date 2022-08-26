namespace InsertionSort
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 9, 3 };
            int n = 3, i, j, val, flag;
            for(i= 0; i < n; i++)
            {
                val= arr[i];
                flag = 0;
                for (j=i-1; j>=0 && flag!=1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            foreach(int ele in arr)
            {
                Console.WriteLine(ele);
            }

        }
    }
    }
        string str1 = "heart";
        string str2 = "earth";

        char[] chr1 = str1.ToLower().ToCharArray();
        char[] chr2 = str2.ToLower().ToCharArray();
       
   Array.Sort(chr1);
   Array.Sort(chr2);

    string val1 = 
    }
}
