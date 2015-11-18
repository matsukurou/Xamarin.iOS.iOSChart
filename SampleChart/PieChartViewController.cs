using System;
using UIKit;
using Foundation;
using CoreGraphics;
using ObjCRuntime;
using System.Drawing;

namespace SampleChart
{
    public partial class PieChartViewController : UIViewController
    {
        public PieChartViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var v = new iOSChart.PieChartView();
            //var v = PieChartSampleView.Create();
            v.Frame = View.Frame;
            View.AddSubview (v);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

