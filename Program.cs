namespace BinaryTreeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BinaryTreeEX binaryTree = new BinaryTreeEX();

            // binaryTree.Add(65);
            //  binaryTree.Add(70);
            //  binaryTree.Add(60);
            // binaryTree.Add(50);
            // binaryTree.Add(30);
            // binaryTree.Add(85);
            //  binaryTree.Add(10);
            // binaryTree.Add(95);

            // binaryTree.TravarsePreorder(binaryTree.Root);

            //  BubbleSort.DisplayBubble();

            //  InsertionSort insertionSort = new InsertionSort();

            // InsertionSort.Insertionsort();


            //Anagram.CheckAnagram();

            // MergeSort.merge()
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            printArray(arr);
            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
    }
}
