using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Topic topic1 = new Topic("Scholarship");
            Topic topic2 = new Topic("Academic");
            Topic topic3 = new Topic("Announcement");
            User u1, u2, u3, u4, u5;
            u1 = new Student();
            u2 = new Lecturer();
            u3 = new Student();
            u4 = new Lecturer();
            u5 = new Student();
            u1.Subscribe(topic1);


/*            topic1.Subscribe(u1);
            topic1.Subscribe(u3);
            topic1.Subscribe(u5);
            topic2.Subscribe(u1);
            topic2.Subscribe(u2);
            topic2.Subscribe(u3);
            topic2.Subscribe(u4);
            topic2.Subscribe(u5);
            topic3.Subscribe(u2);
            topic3.Subscribe(u3);
            topic3.Subscribe(u5);*/

            topic1.AddNews("Scholarship - 2016-04-20");
            topic2.AddNews("Midterm Examination Schedule");


        }
    }
}
