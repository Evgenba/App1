// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace App1.iOS
{
	[Register ("CollectionTest")]
	partial class CollectionTest
	{
		[Outlet]
		UIKit.UICollectionView CollectionView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CollectionView != null) {
				CollectionView.Dispose ();
				CollectionView = null;
			}

		}
	}
}
