using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //Hashtable ht = new Hashtable();
            //SortedList sortedList = new SortedList();
            //Stack stack = new Stack(); -> Non Generic/add any type of data type/LIFO
            //Queue queue = new Queue();

            //Stack stack = new Stack();
            //stack.Push("Bumrah");
            //stack.Push("Dhawan");
            //stack.Push("Rohit");
            //stack.Push("Kohli");
            //stack.Push("Dhoni");

            //Console.WriteLine("# of Items in stack are: " +stack.Count);
            //foreach(var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //stack.Pop();  //we can't remove a particular item, it will follow the sequence of LIFO
            //Console.WriteLine("After removing 1 item:" + stack.Pop());
            //Console.WriteLine("After removing 1 item:" + stack.Pop());
            //Console.WriteLine("# of Items in stack are: " + stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("Peek Example: \t"+stack.Peek());
            //Console.WriteLine("After Peek");
            //Console.WriteLine("# of items in stack: \t"+stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //stack.Clear();
            //Console.WriteLine("After Clear, # of items in Stack:\t"+stack.Count);
            //Console.ReadKey();


            Queue queue = new Queue();// FIFO
                                      //queue.Enqueue("Taylor S"); //To enter into queue we use enqueue
                                      //queue.Enqueue("Camila C");
                                      //queue.Enqueue("Selena G");
                                      //queue.Enqueue("Dua L");
                                      //queue.Enqueue("Britney S");
                                      //Console.WriteLine("# of items in Queue:\t"+queue.Count);
                                      //foreach (var item in queue)
                                      //{
                                      //    Console.WriteLine(item);
                                      //}


            //Console.WriteLine("\n");
            //Console.WriteLine("After removing "+queue.Dequeue()); // Dequeue to pop from queue
            //Console.WriteLine("After removing " + queue.Dequeue());
            //Console.WriteLine("# of items in Queue:\t" + queue.Count);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("Peek Example\t" +queue.Peek());
            //Console.WriteLine("After Peek");
            //Console.WriteLine("# of items in queue: \t"+queue.Count);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n");
            //queue.Clear();
            //Console.WriteLine("After Clear, # of items in queue: " +queue.Count);

            //Console.ReadKey();


            //GENERIC COLLECTION
            // ArrayList arrayList = new ArrayList();
            // Hashtable hastable = new Hashtable();
            // SortedList sortedList = new SortedList();   
            // Stack stack= new Stack();
            // Queue queue1 = new Queue();
            // System.Collections-> they are not type safe/ can any data type

            //example

            //ArrayList arrayList=new ArrayList()
            //{ 1,"Selena",'A',DateTime.Now};
            //Console.WriteLine("item\t DataType");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item+"\t"+item.GetType());
            //}
            //Console.WriteLine("\n");
            //ArrayList nameList = new ArrayList() { "Ethan", "Benji", "Luther" };
            //Console.WriteLine("Name List as follows with Count:" +nameList.Count);
            //foreach (var item  in nameList)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.ReadKey();



            // System.Collections.Generic

            //List<string> list = new List<string>()
            //{ "Ethan", "Benji","Luther"};
            //Console.WriteLine("Name List\n");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.Add("Ilsa");
            //Console.WriteLine("\nAfter adding to Name List\n");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> list2 = new List<int>()
            //{12,23,45,56};
            //Console.WriteLine("\n# List\n");
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //list2.Add(67);
            //Console.WriteLine("\nAfter adding to # List\n");
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();



            //Dictionary<int, string> dict = new Dictionary<int, string>() {
            //{ 1,"Ethan H"},
            //{ 2,"Benji D"},
            //{ 3,"Luther S"}
            // };

            //Console.WriteLine("# of agents: " + dict.Count);
            //Console.WriteLine("Id:\t Name: ");
            //foreach (var k in dict.Keys)
            //{
            //    Console.WriteLine(k + "\t" + dict[k]);
            //}
            //dict.Add(4, "Ilsa F");
            //Console.WriteLine("\nUpdated List");
            //Console.WriteLine("Id:\t Name: ");
            //foreach (var k in dict.Keys)
            //{
            //    Console.WriteLine(k + "\t" + dict[k]);
            //}
            //Console.ReadKey();


            //SortedList<int, string> sList = new SortedList<int, string>() {
            //{ 1,"Ethan H"},
            //{ 2,"Benji D"},
            //{ 3,"Luther S"}
            // };

            //Console.WriteLine("# of agents: " + sList.Count);
            //Console.WriteLine("Id:\t Name: ");
            //foreach (var k in sList.Keys)
            //{
            //    Console.WriteLine(k + "\t" + sList[k]);
            //}

            //sList.Add(4, "Ilsa F");
            //Console.WriteLine("\nUpdated List");
            //Console.WriteLine("Id:\t Name: ");
            //foreach (var k in sList.Keys)
            //{
            //    Console.WriteLine(k + "\t" + sList[k]);
            //}
            //Console.ReadKey();

            SortedList<string, int> hardwareList = new SortedList<string, int>()
            {
                {"CD\t",670},
                {"FDD\t",900 },
                {"HDD\t",120 },
                {"RAM\t",340 }
            };
            Console.WriteLine("Short Form \t Price");
            foreach (var k in hardwareList.Keys)
            {

                Console.WriteLine(k + "\t" + hardwareList[k]);
            }
            Console.ReadKey();
        }
    }
}