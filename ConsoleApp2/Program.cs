using NPOI.SS.Formula.Functions;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyCollection<string> myCollection = new MyCollection<string>();
            myCollection.CollectionEvent += Listener;
            myCollection.Add("Shazia");
            myCollection.Add("Idrees");
            myCollection.Add("Is the");
            myCollection.Add("best");

            myCollection.Remove("Is the");
            myCollection.Add("hello is");
            myCollection.CountItem("0");
        }
        public static void Listener(object sender, CollectionEvent<string> collEve)
        {
            Console.WriteLine($"you {collEve.Reason} Item : {collEve.Item} ");
        }

    }
    public class MyCollection<T>
    {
        public event MyDelegate<T> CollectionEvent;

        private List<T> _collection= new List<T> ();

        public int Id { get; set; }
        public void Add(T item)
        {
            _collection.Add (item);
            FireEvent(item,"Add");
        }
        public void Remove(T item)
        {
            _collection.Remove (item);
            FireEvent(item, "Remove");
        }
        public void CountItem(T item)
        {
            var count =_collection.Count().ToString();
            FireEvent(item, count);
            Console.WriteLine(count);
        }
        private void FireEvent(T item, string reason) /// Firing event
        {
            T Item = item;
            string Reason = reason;
            var evCol = new CollectionEvent<T>(reason, item);
            if(CollectionEvent != null) // raising the event
            {
                CollectionEvent(this, evCol);
            }
        }
    }

    public delegate void MyDelegate<T>(object obj, CollectionEvent<T> collectionEvent);

    public class CollectionEvent<T>:EventArgs
    {
        public string Reason { get; set; }
        public T Item { get; set; }
        public CollectionEvent(string reason, T item)
        {
            Reason = reason;
            Item = item;
        }
    }
    public class Student : Ipen
    {
        public int Id = 10;
        public string name = "sttt";

        int Ipen.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Ipen.name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Copy()
        {
            throw new NotImplementedException();
        }
    }
    public interface Ipen
    {
        public int Id { get; set; }
        public string name { get; set; }

        public void Copy();
       
    }
}