
namespace Week9Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numberList = new List<int>();
            numberList.Add(1);
            printList(numberList);

            //Console.WriteLine("Size: " + numberList.Count);

            numberList.AddRange([2,100, 5, 7, 9]);
            Console.WriteLine($"Size: {numberList.Count} | Capacity: {numberList.Capacity}");
            printList(numberList);

            Console.WriteLine();
            numberList.Sort();
            printList(numberList);

            
            Console.WriteLine($"Index of 5:{numberList.BinarySearch(5)}");
            Console.WriteLine($"Index of 6:{numberList.BinarySearch(6)}");
            numberList.Reverse();
            printList(numberList);

            List<int> lessThan5 = numberList.Where(x => x <= 5).ToList();
            printList(lessThan5);
            List<int> lessThan0 = numberList.ToArray().Where(x => x <= 0).DefaultIfEmpty().ToList();
            printList(lessThan0);
            List<int> squaredList = numberList.Where(x => x >0).Select(x =>  (int)Math.Pow(x, 2)).ToList(); // >= or <= for booleans => for lambdas
            printList(squaredList);
            List<int> cubedList = numberList.Where(x => x > 0).Select(x=> (int)Math.Pow(x,3)).ToList();
            printList(cubedList);
            List<int> orderedCubedList = numberList.Where(x => x > 0).Select(x => (int)Math.Pow(x, 3)).OrderBy(x=> x).ToList();
            printList(orderedCubedList);

            Stack <string> studentsStack = new Stack <string>();
            studentsStack.Push("Caleb");
            Console.WriteLine(studentsStack.Peek());
            studentsStack.Push("Nikembi");
            Console.WriteLine(studentsStack.Peek());
            studentsStack.Push("John");
            Console.WriteLine(studentsStack.Peek());
            studentsStack.Push("Robert");
            Console.WriteLine(studentsStack.Peek());
            Console.WriteLine(studentsStack.Pop());
            Console.WriteLine(studentsStack.Pop());
            Console.WriteLine(studentsStack.Pop());
            Console.WriteLine(studentsStack.Pop());

            Queue <string> studentsQueue = new Queue <string>();
            studentsQueue.Enqueue("Robert");
            studentsQueue.Enqueue("Nikembi");
            studentsQueue.Enqueue("Caleb");
            studentsQueue.Enqueue("John");
            Console.WriteLine(studentsQueue.Dequeue());
            Console.WriteLine(studentsQueue.Dequeue());
            Console.WriteLine(studentsQueue.Dequeue());
            Console.WriteLine(studentsQueue.Dequeue());
        }
        public static void printList(List<int> list)
        {
            Console.WriteLine($"Size: {list.Count} | Capacity: {list.Capacity}");
            Console.WriteLine($"Min: {list.Min()} | Max: {list.Max()}");
            Console.WriteLine($"Average: {list.Average()} | Sum: {list.Sum()}");
            foreach (int i in list)
            {
                Console.Write($"{i} | ");
            }
            Console.WriteLine();
        }
    }
}
