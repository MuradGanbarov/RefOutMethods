
//TASK 1

//namespace RefOut_Methods
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5 };
//            Console.WriteLine("Original Array: " + string.Join(", ", arr));

//            ArrayResize(ref arr, 2, 6, 7, 8);

//            Console.WriteLine("New Array: " + string.Join(", ", arr));
//        }
//        public static void ArrayResize(ref int[] arr, params int[] num)
//        {
//            int[] copy = new int[arr.Length + 1];

//            for (int i = 0; i < arr.Length; i++)
//            {
//                copy[i] = arr[i];
//            }

//            copy[copy.Length - 1] = arr.Length;

//            arr = copy;

//        }
//    }
//}