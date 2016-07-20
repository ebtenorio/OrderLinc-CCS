// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;
using CoreGraphics;

using Foundation;
using UIKit;

using SignaturePad;

namespace OneTradeCentral.iOS
{
	public partial class SignatureView : UIView
	{
		public SignaturePadView signature { get; set; }

		public SignatureView (IntPtr handle) : base (handle)
		{
			signature = new SignaturePadView ();

			//Add the signature subview.
			AddSubview (signature);
		}

		public override void LayoutSubviews ()
		{
//			base.LayoutSubviews ();
			///Using different layouts for the iPhone and iPad, so setup device specific requirements here.
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone)
				signature.Frame = new CGRect (10, 10, Bounds.Width - 20, Bounds.Height - 40);
			else {
				signature.Frame = new CGRect (20, 30, Bounds.Width - 40, Bounds.Height - 50);
			}
		}
	}
}