using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoObserver
{
    public class User
    {
        public virtual void Notify(Topic topic, News item)
        {
            
        }

        internal void Subscribe(Topic topic)
        {
            topic.Subscribe(this);
        }
    }
}