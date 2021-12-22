using System;
using UIKit;
using Foundation;

namespace App1.iOS
{
    public partial class ColCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString (nameof (ColCell));
        public static readonly UINib Nib;

        static ColCell()
        {
            Nib = UINib.FromName("ColCell", NSBundle.MainBundle);
        }

        public ColCell(NSCoder coder)
        {
        }

        public ColCell(IntPtr handler)
            : base(handler)
        {
        }

        public ColCell()
        {

        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            //ContentView.TranslatesAutoresizingMaskIntoConstraints = false;
        }

        public void Configure(string title)
        {
            this.TitleLabel.Text = title;
        }
    }
}