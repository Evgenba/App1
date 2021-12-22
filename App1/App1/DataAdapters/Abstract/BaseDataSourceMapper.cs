namespace Deloitte.Mobile.Cp3.DataAdapters.Abstract
{
    public abstract class BaseDataSourceMapper<TItem>
        where TItem : class
    {
        public abstract int ColumnsNumber { get; }
        public abstract string GetItemColumnValue(TItem item, int columnIndex);
    }
}