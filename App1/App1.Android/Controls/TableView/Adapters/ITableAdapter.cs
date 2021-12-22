using Android.Database;
using Android.Views;

namespace Deloitte.Mobile.Cp3.Droid.Controls.TableView.Adapters
{
    /// <summary>
    /// The TableAdapter object acts as a bridge between an TableFixHeaders and the
    /// underlying data for that view. The Adapter provides access to the data items.
    /// The Adapter is also responsible for making a View for each item in the data
    /// </summary>
    public interface ITableAdapter
    {
        /// <summary>
        /// An item view type that causes the AdapterView to ignore the item view.
        /// For example, this can be used if the client does not want a particular
        /// view to be given for conversion in
        /// {@link #getView(int, int, View, ViewGroup)}.
        /// @see #getItemViewType(int, int)
        /// </summary>
        public static int IGNORE_ITEM_VIEW_TYPE = -1;


        /// <summary>
        /// Register an observer that is called when changes happen to the data used by this adapter.
        /// </summary>
        /// <param name="observer">the object that gets notified when the data set changes</param>
        void RegisterDataSetObserver(DataSetObserver observer);


        /// <summary>
        /// Unregister an observer that has previously been registered with this adapter via {@link #registerDataSetObserver}.
        /// </summary>
        /// <param name="observer">the object to unregister</param>
        void UnregisterDataSetObserver(DataSetObserver observer);

        /// <summary>
        /// How many rows are in the data table represented by this Adapter.
        /// </summary>
        /// <returns>count of rows</returns>
        public int GetRowCount();

        /// <summary>
        /// How many columns are in the data table represented by this Adapter
        /// </summary>
        /// <returns>count of columns</returns>
        public int GetColumnCount();

        /// <summary>
        /// Get a View that displays the data at the specified row and column in the
        /// data table. You can either create a View manually or inflate it from an
        /// XML layout file.
        /// </summary>
        /// <param name="row">The row of the item within the adapter's data table of the item whose view we want. If the row is <code>-1</code> it is the header.</param>
        /// <param name="column">The column of the item within the adapter's data table of the item whose view we want. If the column is <code>-1</code> it is the header</param>
        /// <param name="convertView"></param>
        /// <param name="parent">The parent that this view will eventually be attached to</param>
        /// <returns>A View corresponding to the data at the specified row and column</returns>
        public View GetView(int row, int column, View convertView, ViewGroup parent);

        /// <summary>
        /// Return the width of the column
        /// </summary>
        /// <param name="column">the column. If the column is <code>-1</code> it is the header</param>
        /// <returns>The width of the column, in pixels</returns>
        public int GetWidth(int column);

        /// <summary>
        /// Return the height of the row
        /// </summary>
        /// <param name="row">the row. If the row is <code>-1</code> it is the header</param>
        /// <returns>The height of the row, in pixels</returns>
        public int GetHeight(int row);

        /// <summary>
        /// Get the type of View that will be created by
        /// {@link #getView(int, int, View, ViewGroup)} for the specified item
        /// <param name="row">The row of the item within the adapter's data table of the item whose view we want. If the row is <code>-1</code> it is the header</param>
        /// <param name="column">The column of the item within the adapter's data table of the item whose view we want. If the column is <code>-1</code> it is the header</param>
        /// <returns>An integer representing the type of View.
        /// Two views should share the same type if one can be converted to the other in {@link #getView(int, int, View, ViewGroup)}).
        /// Note: Integers must be in the range 0 to {@link #getViewTypeCount()} - 1.
        /// {@link #IGNORE_ITEM_VIEW_TYPE} can also be returned</returns>
        public ItemViewType GetItemViewType(int row, int column);

        /// <summary>
        /// Returns the number of types of Views that will be created by
        /// {@link #getView(int, int, View, ViewGroup)}. Each type represents a set
        /// of views that can be converted in
        /// {@link #getView(int, int, View, ViewGroup)}. If the adapter always
        /// returns the same type of View for all items, this method should return 1.
        /// This method will only be called when when the adapter is set on the the AdapterView.
        /// </summary>
        /// <returns>The number of types of Views that will be created by this adapter</returns>
        public int GetViewTypeCount();
    }
}