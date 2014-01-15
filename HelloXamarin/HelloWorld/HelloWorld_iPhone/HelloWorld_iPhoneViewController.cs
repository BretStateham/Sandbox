using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld_iPhone
{
	public partial class HelloWorld_iPhoneViewController : UIViewController
	{
		protected int _numberOfTimesClicked = 0;

		public HelloWorld_iPhoneViewController () : base ("HelloWorld_iPhoneViewController", null)
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

			btnClickMe.TouchUpInside += (sender, e) => { 
				lblOutput.Text = string.Format("You \"Clicked Me\" {0} times!", ++_numberOfTimesClicked);
			};
		}

		partial void actnButtonClick (NSObject sender)
		{
			UIButton button = sender as UIButton;
			if(button != null)
				lblOutput.Text = string.Format("You clicked the \"{0}\" button!", button.CurrentTitle);
		}
	}
}

