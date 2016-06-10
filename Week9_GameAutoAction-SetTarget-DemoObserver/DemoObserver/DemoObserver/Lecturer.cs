using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoObserver
{
    public class Lecturer : User
    {
        public override void Notify(Topic topic, News item)
        {
            Console.WriteLine("Lecturer: receiving from " +
                topic.Name + " the news " + item.Content);
            Console.WriteLine("I will read the topic");
            Console.WriteLine("I may share it to my classes");
            Console.WriteLine("---------");
        }
    }
}