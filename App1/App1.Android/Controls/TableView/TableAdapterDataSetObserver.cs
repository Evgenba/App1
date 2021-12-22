using Android.Database;

namespace Deloitte.Mobile.Cp3.Droid.Controls.TableView
{
    internal class TableAdapterDataSetObserver : DataSetObserver
    {
        public Cp3TableView TableView { get; set; }

        public override void OnChanged()
        {
            TableView.NeedRelayout = true;
            TableView.RequestLayout();
        }

        public override void OnInvalidated()
        {
            // Do nothing
        }
    }
}