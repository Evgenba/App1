using Android.Database;
using Android.Views;

namespace Deloitte.Mobile.Cp3.Droid.Controls.TableView.Adapters
{
    public abstract class BaseTableAdapter : ITableAdapter
    {
        protected DataSetObservable DataSetObservable { get; } = new DataSetObservable();

        public void RegisterDataSetObserver(DataSetObserver observer)
        {
            DataSetObservable.RegisterObserver(observer);
        }

        public void UnregisterDataSetObserver(DataSetObserver observer)
        {
            DataSetObservable.UnregisterObserver(observer);
        }

        public abstract int GetRowCount();

        public abstract int GetColumnCount();

        public abstract View GetView(int row, int column, View convertView, ViewGroup parent);

        public abstract int GetWidth(int column);

        public abstract int GetHeight(int row);

        public abstract ItemViewType GetItemViewType(int row, int column);

        public abstract int GetViewTypeCount();

        /// <summary>
        /// Notifies the attached observers that the underlying data has been changed and any View reflecting the data set should refresh itself
        /// </summary>
        public void NotifyDataSetChanged()
        {
            DataSetObservable.NotifyChanged();
        }

        /// <summary>
        /// Notifies the attached observers that the underlying data is no longer valid or available. Once invoked this adapter is no longer valid and should not report further data set changes
        /// </summary>
        public void NotifyDataSetInvalidated()
        {
            DataSetObservable.NotifyInvalidated();
        }
    }
}