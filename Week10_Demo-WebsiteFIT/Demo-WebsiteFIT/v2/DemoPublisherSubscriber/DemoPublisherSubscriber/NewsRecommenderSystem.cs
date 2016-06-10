using System;

namespace DemoPublisherSubscriber
{
    internal class NewsRecommenderSystem
    {
        private static RecommenderSystemHelper helper = new OneKeywordMatching();
            //new DummyHelper();
        internal static bool IsAppropriate(SinhVien sv, Tin tinMoi)
        {
            return helper.IsAppropriate(sv, tinMoi);
        }
    }
}