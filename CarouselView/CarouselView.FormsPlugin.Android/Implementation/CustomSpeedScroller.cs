using Android.Content;
using Android.Views.Animations;
using Android.Widget;

namespace CarouselView.FormsPlugin.Android.Implementation
{
	public class CustomSpeedScroller : Scroller
    {
        public int TransitionDuration { get; set; }

        public CustomSpeedScroller(Context context) : base(context)
        {
        }

        public CustomSpeedScroller(Context context, IInterpolator interpolator) : base(context, interpolator)
        {
        }

        public CustomSpeedScroller(Context context, IInterpolator interpolator, bool flywheel) : base(context, interpolator, flywheel)
        {
        }

        public override void StartScroll(int startX, int startY, int dx, int dy)
        {
            base.StartScroll(startX, startY, dx, dy, TransitionDuration);
        }

        public override void StartScroll(int startX, int startY, int dx, int dy, int duration)
        {
            base.StartScroll(startX, startY, dx, dy, TransitionDuration);
        }
    }
}
