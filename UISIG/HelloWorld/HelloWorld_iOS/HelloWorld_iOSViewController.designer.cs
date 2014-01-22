// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace HelloWorld_iOS
{
	[Register ("HelloWorld_iOSViewController")]
	partial class HelloWorld_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton ClickMeButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel OutputLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickMeButton != null) {
				ClickMeButton.Dispose ();
				ClickMeButton = null;
			}

			if (OutputLabel != null) {
				OutputLabel.Dispose ();
				OutputLabel = null;
			}
		}
	}
}
