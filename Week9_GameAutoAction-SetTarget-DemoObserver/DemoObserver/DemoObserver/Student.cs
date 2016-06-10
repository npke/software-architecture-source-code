using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoObserver
{
    public class Student : User
    {
        public override void Notify(Topic topic, News item)
        {
            Console.WriteLine("Student: receiving from " + 
                topic.Name + " the news " + item.Content);
            Console.WriteLine("I may ignore or forget to read this topic");
            Console.WriteLine("I will troll this topic");
            Console.WriteLine("---------");
        }
    }
}