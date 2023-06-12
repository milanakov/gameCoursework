using System;
using AppKit;

namespace MacOSApp_Game_2
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            /* Specify the file path to the image
            string imagePath = "/Users/milana/Desktop/uni/knu/coursework/MacOSApp_Game_2/MacOSApp_Game_2" +
                               "/Resources/mainScene.png";
            
            // Create an NSImage from the file path
            NSImage backgroundImage = new NSImage(imagePath);
            
            // Create an NSImageView to display the image
            NSImageView imageView = new NSImageView(new CGRect(0, 0, View.Bounds.Width, View.Bounds.Height));
            imageView.AutoresizingMask = NSViewResizingMask.WidthSizable | NSViewResizingMask.HeightSizable; //autoresize
            imageView.Image = backgroundImage;
            imageView.ImageScaling = NSImageScale.ProportionallyUpOrDown;

            // Add the NSImageView as a subview of the main view
            View.AddSubview(imageView);*/
            
            NSColor backgroundColor = NSColor.FromRgb(
                (nfloat)(0x5C / 255.0),   // Red component
                (nfloat)(0x85 / 255.0),   // Green component
                (nfloat)(0x3D / 255.0)    // Blue component
            );

            // Set the background color of the view
            View.WantsLayer = true;
            if (View.Layer != null) View.Layer.BackgroundColor = backgroundColor.CGColor;

            // Do any additional setup after loading the view.
            
        }

    }
}