using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoObserver
{
    public class Topic
    {
        protected List<User> _subscribers = new List<User>();
        protected List<News> _news = new List<News>();
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Topic(string name)
        {
            this.Name = name;
        }

        public bool Subscribe(User user)
        {
            _subscribers.Add(user);
            return true;
        }

        public bool Unsubscribe (User user)
        {
            _subscribers.Remove(user);
            return true;
        }

        public void NotifyAll(News item)
        {
            foreach (User user in _subscribers)
                user.Notify(this, item);
        }

        internal void AddNews(string content)
        {
            _news.Add(new News(content));
            NotifyAll(_news[_news.Count-1]);
        }
    }
}