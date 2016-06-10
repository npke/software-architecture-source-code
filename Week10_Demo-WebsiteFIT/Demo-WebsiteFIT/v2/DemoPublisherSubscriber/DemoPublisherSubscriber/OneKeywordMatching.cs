using System;

namespace DemoPublisherSubscriber
{
    internal class OneKeywordMatching : RecommenderSystemHelper
    {
        public override bool IsAppropriate(SinhVien student, Tin news)
        {
            foreach (string kw in news.TuKhoa)
            {
                if (student.TuKhoa.Contains(kw))
                    return true;
            }
            return false;
        }
    }
}