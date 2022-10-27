using System.ComponentModel;

namespace PracticeInterview
{
    public class Program
    {
        void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4,5,6,7, 8,9,10,11,12,13,14,15 };
            List<int> list = new List<int>();
            int sum = arr[1] + arr[2];
            foreach(int i in arr)
            {
                if(i%sum == 0)
                {
                    list.Add(i);
                    Console.WriteLine(true);
                }
            }
        }
        public class Student
        {
            public int Id { get; set; }
            public void print()
            {
                Console.WriteLine("student class");
            }
        }

    }
    
}