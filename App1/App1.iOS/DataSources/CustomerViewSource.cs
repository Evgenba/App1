using App1.iOS.Data;
using Foundation;
using UIKit;

namespace App1.iOS.DataSources
{
    public class CustomerViewSource : BaseTestViewSource<Customer>
    {
        public CustomerViewSource(UICollectionView collectionView, BaseDataSourceMapper<Customer> itemColumnMapper)
            : base(collectionView, itemColumnMapper)
        {
        }

        public int NumberOfRows => _itemsSource.Count;

        public int NumberOfColumns => _itemColumnMapper.ColumnsNumber;

        protected override UICollectionViewCell DoGetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (UICollectionViewCell)_collectionView.DequeueReusableCell(ColCell.Key, indexPath);
            return cell;
        }

        public override object GetDataForIndexPath(NSIndexPath indexPath)
        {
            var customer = _itemsSource[indexPath.Section];
            var textToDisplay = _itemColumnMapper.GetItemColumnValue(customer, indexPath.Row);
            return textToDisplay;
        }

        protected override void ConfigureCell(UICollectionViewCell cell, object data)
        {
            (cell as ColCell).Configure((string)data);
        }
    }
}