namespace LargestAndSecLargest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int max, secMax;

            Console.WriteLine("Enter the no of elements :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = secMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secMax && arr[i] < max)
                {
                    secMax = arr[i];
                }
            }
            Console.WriteLine("The largest Element is " + max + " and the second largest element is " + secMax);
        }
    }
}
