using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace App1.iOS.DataSources
{
    public abstract class BaseTestViewSource<TItem> : UICollectionViewDataSource
        where TItem : class
    {
        protected readonly UICollectionView _collectionView;
        protected readonly BaseDataSourceMapper<TItem> _itemColumnMapper;
        protected IList<TItem> _itemsSource;

        public BaseTestViewSource(UICollectionView collectionView, BaseDataSourceMapper<TItem> itemColumnMapper)
        {
            _collectionView = collectionView;
            _itemColumnMapper = itemColumnMapper;
        }


        public virtual IList<TItem> ItemsSource
        {
            get
            {
                return _itemsSource;
            }
            set
            {
                _itemsSource = value;
                _collectionView.ReloadData();
            }
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            // number of columns
            return _itemColumnMapper.ColumnsNumber;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            // number of tows
            return (nint)ItemsSource.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = DoGetCell(collectionView, indexPath);
            // todo: bind it
            var item = GetDataForIndexPath(indexPath);
            ConfigureCell(cell, item);
            return cell;
        }

        public abstract object GetDataForIndexPath(NSIndexPath indexPath);

        protected abstract UICollectionViewCell DoGetCell(UICollectionView collectionView, NSIndexPath indexPath);
        protected abstract void ConfigureCell(UICollectionViewCell cell, object data);
    }
}