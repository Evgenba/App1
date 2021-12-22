using System;
using App1.iOS.Data;

namespace App1.iOS.DataSources
{
    public abstract class BaseDataSourceMapper<TItem>
        where TItem : class
    {
        public BaseDataSourceMapper()
        {
        }

        public abstract int ColumnsNumber { get; }
        public abstract string GetItemColumnValue(TItem item, int columnIndex);
    }



    public class CustomerDataSourceMapper : BaseDataSourceMapper<Customer>
    {
        public override int ColumnsNumber => 8;

        public override string GetItemColumnValue(Customer item, int columnIndex)
        {
            //item.ThrowIfNull()

            return item.CustomerToColumnString(columnIndex);
        }
    }


    public static class DataSourceMappers
    {
        public static string CustomerToColumnString(this Customer customer, int columnIndex)
        {
            var columnText = columnIndex switch
            {
                0 => customer.Name,
                1 => customer.LastName,
                2 => customer.FirstName,
                3 => customer.Id.ToString(),
                4 => customer.LastOrderDate.ToString(),
                5 => customer.LastOrderTime.ToString(),
                6 => customer.PostalCode,
                7 => customer.OrderTotal.ToString(),
                8 => customer.OrderAverage.ToString(),

                _ => throw new ArgumentOutOfRangeException(nameof(columnIndex))
            };

            return columnText;
        }

    }
}