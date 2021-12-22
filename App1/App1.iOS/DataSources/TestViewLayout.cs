using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CoreGraphics;
using Foundation;
using UIKit;

namespace App1.iOS.DataSources
{
    public class TestViewLayout : UICollectionViewLayout
    {
        private const int RowHeaderWidth = 70;// 100;
        private const int MinRowHeight = 30;
        // to calculate max height needed to show string value
        private const int MaxRowHeight = 9999;
        private const int Padding_StartEnd = 20;

        private bool shouldPinFirstColumn = true;
        private bool shouldPinFirstRow = true;

        //todo: init it from constructor or mapper?
        // think about fixing column and rows distinctive
        private bool HasFixedRowHeaders = true;


        public IList<IList<UICollectionViewLayoutAttributes>> ItemAttributes;
        public CGSize contentSize = CGSize.Empty;
        private CustomerViewSource customerViewSource;

        private nint numberOfRows;
        private nint numberOfColumns;
        private nfloat[] columnWidths;
        private nfloat[] rowHeights;

        public override void PrepareLayout()
        {
            customerViewSource = CollectionView.DataSource as CustomerViewSource;

            numberOfRows = customerViewSource.NumberOfRows;
            numberOfColumns = customerViewSource.NumberOfColumns;

            if ((ItemAttributes?.Count ?? 0) != numberOfRows)
            {
                GenerateItemAttributes(CollectionView);
                return;
            }

            if (!HasFixedRowHeaders)
            {
                return;
            }

            for (var section = 0; section < numberOfRows; ++section)
            {
                var numberOfItemsInSection = CollectionView.NumberOfItemsInSection(section);

                for (var item = 0; item < numberOfItemsInSection; ++item)
                {
                    if (section != 0 && item != 0)
                    {
                        continue;
                    }

                    var attributes = LayoutAttributesForItem(NSIndexPath.FromItemSection(item: item, section: section));
                    if (section == 0)
                    {
                        var frame = attributes.Frame;
                        frame.Y = CollectionView.ContentOffset.Y;
                        attributes.Frame = frame;
                    }

                    if (item == 0)
                    {
                        var frame = attributes.Frame;
                        frame.X = CollectionView.ContentOffset.X;
                        attributes.Frame = frame;
                    }
                }
            }
        }

        public override bool ShouldInvalidateLayoutForBoundsChange(CGRect newBounds)
        {
            return HasFixedRowHeaders;

            // todo: check for sticked columns/rows headers
            // to invalidate items on each scroll
            return true;
        }

        public override CGSize CollectionViewContentSize => contentSize;

        public override UICollectionViewLayoutAttributes LayoutAttributesForItem(NSIndexPath indexPath)
        {
            return ItemAttributes[indexPath.Section][indexPath.Row];
        }

        public override UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect(CGRect rect)
        {
            var attributes = new List<UICollectionViewLayoutAttributes>();
            foreach (var section in ItemAttributes)
            {
                var filteredArray = section.Where(item => rect.IntersectsWith(item.Frame));

                attributes.AddRange(filteredArray);
            }

            return attributes.ToArray();
        }

        #region prepare

        private void GenerateItemAttributes(UICollectionView collectionView)
        {
            //if (ItemsSize?.Count != customerViewSource.NumberOfRows)
            if (rowHeights?.Length != customerViewSource.NumberOfRows)
            {
                CalculateItemSizes();
            }

        var column = 0;
        nfloat xOffset = 0;
        nfloat yOffset = 0;
        nfloat contentWidth = 0;

        ItemAttributes = new List<IList<UICollectionViewLayoutAttributes>>();

        for (int section = 0; section < numberOfRows; ++section)
        {
            var sectionAttributes = new List<UICollectionViewLayoutAttributes>();

            for(var index = 0; index<numberOfColumns; ++ index)
            {
                //var itemSize = ItemsSize[index];
                var itemSize = new CGSize(width: columnWidths[index], height: rowHeights[section]);
                var indexPath = NSIndexPath.FromItemSection(item: index, section: section);
                var attributes = UICollectionViewLayoutAttributes.CreateForCell(indexPath);

                attributes.Frame = new CGRect(x: xOffset, y: yOffset, width: itemSize.Width, height: itemSize.Height)
                    .Integral();

                if (section == 0 && index == 0)
                {
                    // First cell should be on top
                    attributes.ZIndex = 1024;
                }
                else if (section == 0 || index == 0)
                {
                    // First row/column should be above other cells
                    attributes.ZIndex = 1023;
                }

                if (section == 0)
                {
                    var frame = attributes.Frame;
                    // todo: what is ".origin."?
                    //frame.origin.y = collectionView.contentOffset.y
                    frame.Y = collectionView.ContentOffset.Y;
                    attributes.Frame = frame;
                }

                if (index == 0)
                {
                    var frame = attributes.Frame;

                    // todo: what is ".origin."?
                    //frame.origin.x = collectionView.contentOffset.x
                    frame.X = collectionView.ContentOffset.X;
                    attributes.Frame = frame;
                }

                sectionAttributes.Add(attributes);

                xOffset += itemSize.Width;
                column += 1;

                if (column == numberOfColumns)
                {
                    if (xOffset > contentWidth)
                    {
                        contentWidth = xOffset;
                    }

                    column = 0;
                    xOffset = 0;
                    yOffset += itemSize.Height;
                }
            }

            ItemAttributes.Add(sectionAttributes);
        }

        var attributesLast = ItemAttributes.Last()?.Last();
        if (attributesLast != null)
        {
            contentSize = new CGSize(width: contentWidth, height: attributesLast.Frame.GetMaxY());
        }
        }

        void CalculateItemSizes()
        {
            columnWidths = new nfloat[numberOfColumns];

            for (var columnIndex = 0; columnIndex < numberOfColumns; ++columnIndex)
            {
                columnWidths[columnIndex] = WidthForItemWithColumnIndex(columnIndex);
            }

            rowHeights = new nfloat[numberOfRows];

            for (var index = 0; index < numberOfRows; ++index)
            {
                rowHeights[index] = HeightForItemByRowHeaderItem(index);
            }
        }

        private nfloat WidthForItemWithColumnIndex(int columnIdex)
        {
            if (columnIdex == 0 && HasFixedRowHeaders)
            {
                // first cell in row has a default value always
                return RowHeaderWidth;
            }

            var columnMaxString = string.Empty;

            for (var itemIndex = 0; itemIndex < numberOfRows; ++itemIndex)
            {
                // todo: add abstract method to get string from DATA
                var textToMeasure = (string) customerViewSource.GetDataForIndexPath(NSIndexPath.FromItemSection(columnIdex, itemIndex));

                if (columnMaxString.Length < textToMeasure.Length)
                {
                    columnMaxString = textToMeasure;
                }
            }

            var size = columnMaxString.StringSize(UIFont.SystemFontOfSize(17), new CGSize(width: MaxRowHeight, height: MinRowHeight));
            var width = size.Width + 40;

            return width;
        }

        private nfloat HeightForItemByRowHeaderItem(int rowIndex)
        {
            var headerIndex = 0;

            // get only header
            var textToMeasure = (string) customerViewSource.GetDataForIndexPath(NSIndexPath.FromItemSection(headerIndex, rowIndex));

            var size = textToMeasure.StringSize(UIFont.SystemFontOfSize(17), new CGSize(width: RowHeaderWidth, height: MaxRowHeight), UILineBreakMode.CharacterWrap);

            Debug.WriteLine($"HEIGHT: H/W = {size.Height}/{size.Width}    {textToMeasure}");
            var cellHeight = size.Height > MinRowHeight ? size.Height : MinRowHeight;
            return cellHeight;
        }

        private CGSize SizeForItemWithColumnIndex(int columnIdex, nfloat[] columnWidths)
        {
            var columnMaxString = string.Empty;

            foreach (var customer in customerViewSource.ItemsSource)
            {
                var textTomeasure = customer.CustomerToColumnString(columnIdex);

                if (columnMaxString.Length < textTomeasure.Length)
                {
                    columnMaxString = textTomeasure;
                }
            }

            var size = columnMaxString.StringSize(UIFont.SystemFontOfSize(17), new CGSize(RowHeaderWidth, MinRowHeight));
            var cellHeight = size.Height > MinRowHeight ? size.Height : MinRowHeight;
            var width = size.Width + 40;
            return new CGSize(width: width, height: cellHeight);
        }

        private CGSize SizeForItemWithColumnIndex(int itemIndex)
        {
            var columnMaxString = string.Empty;

            foreach (var customer in customerViewSource.ItemsSource)
            {
                var textTomeasure = customer.CustomerToColumnString(itemIndex);

                if (columnMaxString.Length < textTomeasure.Length)
                {
                    columnMaxString = textTomeasure;
                }
            }

            var size = columnMaxString.StringSize(UIFont.SystemFontOfSize(17), new CGSize(RowHeaderWidth, MinRowHeight));
            var cellHeight = size.Height > MinRowHeight ? size.Height : MinRowHeight;
            var width = size.Width + Padding_StartEnd * 2;
            return new CGSize(width: width, height: cellHeight);
        }

        #endregion
    }
}