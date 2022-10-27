namespace TestJob
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> list = new List<int>();
            int sum = arr[1] + arr[2];
            foreach (int i in arr)
            {
                if (i % sum == 0)
                {
                    list.Add(i);
                    Console.WriteLine(true);
                }
            }
            int n = Convert.ToInt32( Console.ReadLine());
            fibSeries(0, 1, 1, n);

            /////////////////////////////////////////  A N A G A R A M  /////////////////////////////////////
            Console.WriteLine("Enetr first string to find Anagram ?");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enetr second string to find Anagram ?");
            string str2 = Console.ReadLine();


            char[] ch1 = new char[str1.Length];
            char[] ch2 = new char[str2.Length];
            ch1 = str1.ToCharArray();
            ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            if (ch1 == ch1)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not Anagram");

            /////////////////////////////////////////   S O R T I N G ----- A L G O R I T H I M S  /////////////////////////////////////

            int[] arr1 = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            int min=0 ;
            int temp = 0;
            for(int i = 0; i < arr1.Length-1; i++)
            {
                min = i;
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[j] < arr1[min])
                    {
                        min = j;
                    }
                }
                temp = arr1[min];// temp=100
                arr1[min] = arr1[i];// arr[j]=50
                arr1[i] = temp; //arr[j+1]=100
            }
            Console.WriteLine(String.Join(",", arr1));
        }
        static void fibSeries(int a, int b, int counter, int n)
        {
             if(counter <= n)
            {
               Console.WriteLine(a);// a= 0, a+b=1, now a becomes b=1, and b become a+b 
                fibSeries(b, a+b, counter+1, n);
            }
        }
    }
}