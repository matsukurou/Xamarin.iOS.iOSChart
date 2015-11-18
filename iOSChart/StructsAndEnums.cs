using System;
using ObjCRuntime;

namespace iOSChart
{
	[Native]
	public enum ApproximatorType : ulong
	{
		None = 0,
		RamerDouglasPeucker = 1
	}

	[Native]
    public enum ChartEasingOption : ulong
	{
		Linear = 0,
		EaseInQuad = 1,
		EaseOutQuad = 2,
		EaseInOutQuad = 3,
		EaseInCubic = 4,
		EaseOutCubic = 5,
		EaseInOutCubic = 6,
		EaseInQuart = 7,
		EaseOutQuart = 8,
		EaseInOutQuart = 9,
		EaseInQuint = 10,
		EaseOutQuint = 11,
		EaseInOutQuint = 12,
		EaseInSine = 13,
		EaseOutSine = 14,
		EaseInOutSine = 15,
		EaseInExpo = 16,
		EaseOutExpo = 17,
		EaseInOutExpo = 18,
		EaseInCirc = 19,
		EaseOutCirc = 20,
		EaseInOutCirc = 21,
		EaseInElastic = 22,
		EaseOutElastic = 23,
		EaseInOutElastic = 24,
		EaseInBack = 25,
		EaseOutBack = 26,
		EaseInOutBack = 27,
		EaseInBounce = 28,
		EaseOutBounce = 29,
		EaseInOutBounce = 30
	}

	[Native]
	public enum ChartLegendPosition : ulong
	{
		RightOfChart = 0,
		RightOfChartCenter = 1,
		RightOfChartInside = 2,
		LeftOfChart = 3,
		LeftOfChartCenter = 4,
		LeftOfChartInside = 5,
		BelowChartLeft = 6,
		BelowChartRight = 7,
		BelowChartCenter = 8,
		AboveChartLeft = 9,
		AboveChartRight = 10,
		AboveChartCenter = 11,
		PiechartCenter = 12
	}

	[Native]
	public enum ChartLegendForm : ulong
	{
		Square = 0,
		Circle = 1,
		Line = 2
	}

	[Native]
	public enum ChartLegendDirection : ulong
	{
		LeftToRight = 0,
		RightToLeft = 1
	}

	[Native]
	public enum ChartLimitLabelPosition : ulong
	{
		LeftTop = 0,
		LeftBottom = 1,
		RightTop = 2,
		RightBottom = 3
	}

	[Native]
	public enum XAxisLabelPosition : ulong
	{
		Top = 0,
		Bottom = 1,
		BothSided = 2,
		TopInside = 3,
		BottomInside = 4
	}

	[Native]
	public enum YAxisLabelPosition : ulong
	{
		OutsideChart = 0,
		InsideChart = 1
	}

	[Native]
	public enum AxisDependency : ulong
	{
		Left = 0,
		Right = 1
	}

	[Native]
	public enum CombinedChartDrawOrder : ulong
	{
		Bar = 0,
		Bubble = 1,
		Line = 2,
		Candle = 3,
		Scatter = 4
	}

	[Native]
	public enum ScatterShape : ulong
	{
		Cross = 0,
		Triangle = 1,
		Circle = 2,
		Square = 3,
		Custom = 4
	}
}
