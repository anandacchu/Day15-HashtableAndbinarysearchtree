namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
               Console.WriteLine("Welcome to Hash Tables and Binary Search Tree program");
             BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);

            binarySearch.Display();

            binarySearch.GetSize();
        }
    }
}
