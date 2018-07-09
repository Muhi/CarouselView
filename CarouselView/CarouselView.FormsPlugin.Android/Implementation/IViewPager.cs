using System;
using CarouselView.FormsPlugin.Abstractions;

namespace CarouselView.FormsPlugin.Android
{
    public interface IViewPager
    {
        void SetTransitionDuration(int duration);
        void SetPagingEnabled(bool enabled);
        void SetElement(CarouselViewControl element);
    }
}
