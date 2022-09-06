namespace BinarySearchTree
{
    class program
    {
        public static void Main(string[] args)
        {
           

            int[] arr = { 70, 30, 42, 55, 10 };
            int temp;
            for(int j=0;j<=arr.Length-2;j++)
            {
                for(int i=0;i<=arr.Length-2;i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        temp = arr[i + 1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array");
            foreach (int ele in arr)
            {
                Console.Write(ele + " ");
            }
        }
    }
}
