//List<int> numbers = new List<int>();

//numbers.Add(0);
//numbers.Add(1);
//numbers.Add(2);
//Console.WriteLine(numbers.Exists(item => item == 8));

using ConsoleApp4;

List<int> ints = new List<int>()
{
    1,2,3
};

MyList<int> myList = new MyList<int>();

myList.Add(1);
myList.Add(1);
myList.Add(1);
myList.Add(1);
myList.Add(1);

Console.WriteLine(myList.Capacity);