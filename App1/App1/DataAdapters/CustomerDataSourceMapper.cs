using Deloitte.Mobile.Cp3.DataAdapters.Abstract;

namespace Deloitte.Mobile.Cp3.DataAdapters
{
    public class CustomerDataSourceMapper : BaseDataSourceMapper<Customer>
    {
        public override int ColumnsNumber => 8;

        public override string GetItemColumnValue(Customer item, int columnIndex)
        {
            //item.ThrowIfNull()

            return item.CustomerToColumnString(columnIndex);
        }
    }
}