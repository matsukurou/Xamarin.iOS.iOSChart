using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ObjCRuntime;

namespace SampleChart
{
	partial class PieChartSampleView : UIView
	{
		public PieChartSampleView (IntPtr handle) : base (handle)
		{
		}

        public static PieChartSampleView Create()
        {
            try{
            var arr = NSBundle.MainBundle.LoadNib ("PieChartSampleView", null, null);
                var v = Runtime.GetNSObject<PieChartSampleView> (arr.ValueAt(0));
                return v;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }


           
        }
	}
}
