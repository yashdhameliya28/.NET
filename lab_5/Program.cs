using System.Collections;

Console.WriteLine("Enter question number : ");
int questionNo = Convert.ToInt32(Console.ReadLine());

switch (questionNo)
{
    case 1:
        ArrayList arrayList = new ArrayList();
        arrayList.Add("heet");
        arrayList.Add("yash");
        arrayList.Add("parth");
        arrayList.Add("utsav");
       
        //foreach(object  obj in arrayList)
        //{
        //    Console.WriteLine(obj.ToString());
        //}

        arrayList.Remove("parth");
        arrayList.RemoveRange(0, 2);
        foreach (object obj in arrayList)
        {
            Console.WriteLine(obj.ToString());
        }
        arrayList.Clear();

        
        break;

    case 2:
        List<string> list = new List<string>();
        list.Add("yash");
        list.Add("heet");
        list.Add("soham");
        list.Add("utsav");
        list.Add("nazil");

        list.Remove("yash");
        Console.WriteLine("-----------------");
        foreach(object obj in list)
        {
            Console.WriteLine(obj.ToString());
        }

        Console.WriteLine("-----------------");

        list.RemoveRange(0,2);
        Console.WriteLine("-----------------");
        foreach (object obj in list)
        {
            Console.WriteLine(obj.ToString());
        }

        Console.WriteLine("-----------------");
        list.Clear();
        break;

    case 3:
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------------");
        stack.Pop();
        int peekElement = Convert.ToInt32(stack.Peek());
        Console.WriteLine(peekElement);

        Console.WriteLine("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (stack.Contains(num))
        {
            Console.WriteLine("Given number is contain in stack");
        }
        else
        {
            Console.WriteLine("Not in stack!!!");
        }

        stack.Clear();

            break;

    case 4:
        Queue queue = new Queue();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);

        Console.WriteLine("--------------------");
        queue.Dequeue();

        int deqElement = Convert.ToInt32(queue.Peek());
        Console.WriteLine(deqElement);

        Console.WriteLine("Enter a number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (queue.Contains(num2))
        {
            Console.WriteLine("Given number found in queue");
        }
        else
        {
            Console.WriteLine("Not found!!!");
        }

        queue.Clear();
            break;

    case 5:
        Dictionary<int, string> dic = new Dictionary<int, string>();

        dic.Add(1, "yash");
        dic.Add(2, "heet");
        dic.Add(3, "soham");
        dic.Add(4, "raj");
        dic.Add(5, "utsav");
        dic.Add(6, "nazil");

        dic.Remove(4);

        Console.WriteLine("---------------");
        foreach(var key in dic.Keys)
        {
            Console.WriteLine(dic[key]);
        }

        Console.WriteLine("-------------------");

        Console.WriteLine("Enter a key value : ");
        int uKey = Convert.ToInt32(Console.ReadLine());

        if (dic.ContainsKey(uKey)) {
            Console.WriteLine("key found");
        }
        else
        {
            Console.WriteLine("key not found");
        }

        Console.WriteLine("Enter a value to check in dictionary : ");
        int uValue = Convert.ToInt32(Console.ReadLine());

        if (dic.ContainsKey(uValue))
        {
            Console.WriteLine("dictionary contain given value");
        }
        else
        {
            Console.WriteLine("dictionary not contain given value");
        }

        dic.Clear();

        break;

        case 6:
            Hashtable hashtable = new Hashtable();

        hashtable.Add(1, "yash");
        hashtable.Add(2, "heet");
        hashtable.Add(3, "soham");
        hashtable.Add(4, 100);
        hashtable.Add(5, 500);

        Console.WriteLine("--------------");
        hashtable.Remove(2);

            foreach( var key in hashtable.Keys)
        {
            Console.WriteLine(hashtable[key]);
        }

        Console.WriteLine("Enter a key value : ");
        int hashKey = Convert.ToInt32(Console.ReadLine());

        if (hashtable.ContainsKey(hashKey))
        {
            Console.WriteLine("key found");
        }
        else
        {
            Console.WriteLine("key not found");
        }

        Console.WriteLine("Enter a value to check in dictionary : ");
        int hashValue = Convert.ToInt32(Console.ReadLine());

        if (hashtable.ContainsKey(hashKey))
        {
            Console.WriteLine("hashtable contain given value");
        }
        else
        {
            Console.WriteLine("hashtable not contain given value");
        }

        hashtable.Clear();
        break;
}