using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld_iOS
{
	public partial class HelloWorld_iOSViewController : UIViewController
	{
		public HelloWorld_iOSViewController () : base ("HelloWorld_iOSViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.ClickMeButton.TouchUpInside += (sender, e) => {
				OutputLabel.Text = "You clicked me!";
			};
		}
	}
}

