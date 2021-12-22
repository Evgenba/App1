using System.Collections.Generic;
using System.Linq;
using Android.Views;
using Deloitte.Mobile.Cp3.Droid.Controls.TableView.Adapters;


namespace Deloitte.Mobile.Cp3.Droid.Controls.TableView
{
    // todo: think about EndlessRecyclerView
    public class Cp3TableRecycler
    {
        // todo: add register method
        private Stack<View>[] views;

        public Cp3TableRecycler(int recycledStackSize)
        {
            InitializeRecyclingStack(recycledStackSize);
        }

        private void InitializeRecyclingStack(int recycledStackSize)
        {
            views = new Stack<View>[recycledStackSize];

            for (int i = 0; i < recycledStackSize; i++)
            {
                views[i] = new Stack<View>();
            }
        }

        /// <summary>
        /// Add a view to the Recycler. This view may be reused in the function
        /// </summary>
        /// <param name="view">A view to add to the Recycler. It can no longer be used</param>
        /// <param name="type">the type of the view</param>
        public void AddRecycledView(View view, int type)
        {
            views[type].Push(view);
        }


        /// <summary>
        /// Returns, if exists, a view of the type <see cref="typeView"/>
        /// </summary>
        /// <param name="typeView">the type of view that you want</param>
        /// <returns>a view of the type <see cref="typeView"/>. Null if not found</returns>
        public View GetRecycledView(ItemViewType typeView)
        {
            try
            {
                if (views?.Any() == true)
                {
                    return views[(int)typeView].Pop();
                }
            }
            catch (Java.Util.EmptyStackException e)
            {
                // do nothing
            }

            return null;
        }
    }
}