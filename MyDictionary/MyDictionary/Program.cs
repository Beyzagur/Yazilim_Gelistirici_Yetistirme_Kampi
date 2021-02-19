using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(2018510035, "Beyza");
            myDictionary.Add(1234567890, "name1");
            myDictionary.Add(1122334455, "name2");
            myDictionary.Add(1472583690, "name3");
            myDictionary.Add(1594872630, "name4");

            myDictionary.Key(2018510035);
            myDictionary.Value("name3");
            Console.WriteLine(myDictionary.ContainsKey(0126534789));
            Console.WriteLine(myDictionary.ContainsValue("name2"));
            
        }
    }
}
