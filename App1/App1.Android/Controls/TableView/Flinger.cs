using System;
using Android.Widget;
using Java.Lang;

namespace Deloitte.Mobile.Cp3.Droid.Controls.TableView
{
    // http://stackoverflow.com/a/6219382/842697
    internal class Flinger : IDisposable
    {
        private readonly Runnable runnable;
        private readonly Cp3TableView tableView;
        private readonly Scroller scroller;

        private int lastX = 0;
        private int lastY = 0;

        public Flinger(Android.Content.Context context, Cp3TableView tableView)
        {
            runnable = new Runnable(LocalHandler);

            this.tableView = tableView;
            scroller = new Scroller(context);
        }

        internal void Start(int initX, int initY, int initialVelocityX, int initialVelocityY, int maxX, int maxY)
        {
            scroller.Fling(initX, initY, initialVelocityX, initialVelocityY, 0, maxX, 0, maxY);

            lastX = initX;
            lastY = initY;

            tableView.Post(runnable);
        }

        private void LocalHandler()
        {
            if (scroller.IsFinished)
            {
                return;
            }

            var more = scroller.ComputeScrollOffset();
            int x = scroller.CurrX;
            int y = scroller.CurrY;
            int diffX = lastX - x;
            int diffY = lastY - y;

//            if (Math.abs(diffX) > Math.abs(diffY))
//            {
//                Log.d("###", "diffX > diffY");
//                scrollBy(diffX, lastY);
//                lastX = x;
//            }
//            else {
//
//                Log.d("###", "diffX < diffY");
//                scrollBy(lastX, diffY);
//                lastY = y;
//            }

            if (diffX != 0 || diffY != 0)
            {
                tableView.ScrollBy(diffX, diffY);
                lastX = x;
                lastY = y;
            }

            if (more)
            {
                tableView.Post(runnable);
            }
        }

        public bool IsFinished => scroller.IsFinished;

        public void ForceFinished()
        {
            if (!scroller.IsFinished)
            {
                scroller.ForceFinished(true);
            }
        }

        public void Dispose()
        {
            runnable?.Dispose();
        }
    }
}