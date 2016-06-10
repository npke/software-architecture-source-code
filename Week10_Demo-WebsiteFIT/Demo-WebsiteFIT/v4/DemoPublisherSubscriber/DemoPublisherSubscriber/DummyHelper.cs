using System;

namespace DemoPublisherSubscriber
{
    internal class DummyHelper : RecommenderSystemHelper
    {
        public override bool IsAppropriate(SinhVien student, Tin news)
        {
            return true;
        }
    }
}