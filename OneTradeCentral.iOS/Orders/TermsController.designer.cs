// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace OneTradeCentral.iOS
{
	[Register ("TermsController")]
	partial class TermsController
	{
		[Outlet]
		UIKit.UIPickerView TermsPicker { get; set; }

		[Action ("Save:")]
		partial void Save (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (TermsPicker != null) {
				TermsPicker.Dispose ();
				TermsPicker = null;
			}
		}
	}
}
