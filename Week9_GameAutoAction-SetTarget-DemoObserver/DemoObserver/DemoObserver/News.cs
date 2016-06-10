namespace DemoObserver
{
    public class News
    {
        private string content;

        public News(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }
    }
}