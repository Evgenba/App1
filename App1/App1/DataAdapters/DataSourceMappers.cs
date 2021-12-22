using System;

namespace Deloitte.Mobile.Cp3.DataAdapters
{
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