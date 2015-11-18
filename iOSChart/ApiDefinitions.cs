using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace iOSChart
{
	// @interface ChartData : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
        IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] ChartDataSet[] dataSets);

		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals;
		[Export ("initWithXVals:")]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals);

		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSet:(ChartDataSet * _Nullable)dataSet;
		[Export ("initWithXVals:dataSet:")]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] ChartDataSet dataSet);

		// -(void)notifyDataChanged;
		[Export ("notifyDataChanged")]
		void NotifyDataChanged ();

		// @property (readonly, nonatomic) NSInteger dataSetCount;
		[Export ("dataSetCount")]
		nint DataSetCount { get; }

		// @property (readonly, nonatomic) double average;
		[Export ("average")]
		double Average { get; }

		// @property (readonly, nonatomic) double yMin;
		[Export ("yMin")]
		double YMin { get; }

		// -(double)getYMin;
		[Export ("getYMin")]
        double GetYMin();

		// -(double)getYMin:(enum AxisDependency)axis;
		[Export ("getYMin:")]
		double GetYMin (AxisDependency axis);

		// @property (readonly, nonatomic) double yMax;
		[Export ("yMax")]
		double YMax { get; }

		// -(double)getYMax;
		[Export ("getYMax")]
        double GetYMax ();

		// -(double)getYMax:(enum AxisDependency)axis;
		[Export ("getYMax:")]
		double GetYMax (AxisDependency axis);

		// @property (readonly, nonatomic) double xValAverageLength;
		[Export ("xValAverageLength")]
		double XValAverageLength { get; }

		// @property (readonly, nonatomic) double yValueSum;
		[Export ("yValueSum")]
		double YValueSum { get; }

		// @property (readonly, nonatomic) NSInteger yValCount;
		[Export ("yValCount")]
		nint YValCount { get; }

		// -(void)addXValue:(NSString * _Nullable)xVal;
		[Export ("addXValue:")]
		void AddXValue ([NullAllowed] string xVal);

		// -(void)removeXValue:(NSInteger)index;
		[Export ("removeXValue:")]
		void RemoveXValue (nint index);

		// @property (copy, nonatomic) NSArray * _Nonnull dataSets;
		[Export ("dataSets", ArgumentSemantic.Copy)]
        ChartDataSet[] DataSets { get; set; }

		// @property (readonly, nonatomic) NSInteger xValCount;
		[Export ("xValCount")]
		nint XValCount { get; }

		// -(ChartDataEntry * _Nullable)getEntryForHighlight:(ChartHighlight * _Nonnull)highlight;
		[Export ("getEntryForHighlight:")]
		[return: NullAllowed]
		ChartDataEntry GetEntryForHighlight (ChartHighlight highlight);

		// -(ChartDataSet * _Nullable)getDataSetByLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase;
		[Export ("getDataSetByLabel:ignorecase:")]
		[return: NullAllowed]
		ChartDataSet GetDataSetByLabel (string label, bool ignorecase);

		// -(ChartDataSet * _Null_unspecified)getDataSetByIndex:(NSInteger)index;
		[Export ("getDataSetByIndex:")]
		ChartDataSet GetDataSetByIndex (nint index);

		// -(void)addDataSet:(ChartDataSet * _Null_unspecified)d;
		[Export ("addDataSet:")]
		void AddDataSet (ChartDataSet d);

		// -(void)handleEmptyAxis:(ChartDataSet * _Nullable)firstLeft firstRight:(ChartDataSet * _Nullable)firstRight;
		[Export ("handleEmptyAxis:firstRight:")]
		void HandleEmptyAxis ([NullAllowed] ChartDataSet firstLeft, [NullAllowed] ChartDataSet firstRight);

		// -(BOOL)removeDataSet:(ChartDataSet * _Null_unspecified)dataSet;
		[Export ("removeDataSet:")]
		bool RemoveDataSet (ChartDataSet dataSet);

		// -(BOOL)removeDataSetByIndex:(NSInteger)index;
		[Export ("removeDataSetByIndex:")]
		bool RemoveDataSetByIndex (nint index);

		// -(void)addEntry:(ChartDataEntry * _Nonnull)e dataSetIndex:(NSInteger)dataSetIndex;
		[Export ("addEntry:dataSetIndex:")]
		void AddEntry (ChartDataEntry e, nint dataSetIndex);

		// -(BOOL)removeEntry:(ChartDataEntry * _Null_unspecified)entry dataSetIndex:(NSInteger)dataSetIndex;
		[Export ("removeEntry:dataSetIndex:")]
		bool RemoveEntry (ChartDataEntry entry, nint dataSetIndex);

		// -(BOOL)removeEntryByXIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex;
		[Export ("removeEntryByXIndex:dataSetIndex:")]
		bool RemoveEntryByXIndex (nint xIndex, nint dataSetIndex);

		// -(ChartDataSet * _Nullable)getDataSetForEntry:(ChartDataEntry * _Null_unspecified)e;
		[Export ("getDataSetForEntry:")]
		[return: NullAllowed]
		ChartDataSet GetDataSetForEntry (ChartDataEntry e);

		// -(NSInteger)indexOfDataSet:(ChartDataSet * _Nonnull)dataSet;
		[Export ("indexOfDataSet:")]
		nint IndexOfDataSet (ChartDataSet dataSet);

		// -(ChartDataSet * _Nullable)getFirstLeft;
		[NullAllowed, Export ("getFirstLeft")]
		ChartDataSet FirstLeft { get; }

		// -(ChartDataSet * _Nullable)getFirstRight;
		[NullAllowed, Export ("getFirstRight")]
		ChartDataSet FirstRight { get; }

		// -(NSArray * _Nullable)getColors;
		[NullAllowed, Export ("getColors")]
        UIColor[] Colors { get; }

		// -(NSArray * _Nonnull)generateXVals:(NSInteger)from to:(NSInteger)to;
		[Export ("generateXVals:to:")]
		string[] GenerateXVals (nint from, nint to);

		// -(void)setValueFormatter:(NSNumberFormatter * _Null_unspecified)formatter;
		[Export ("setValueFormatter:")]
		void SetValueFormatter (NSNumberFormatter formatter);

		// -(void)setValueTextColor:(UIColor * _Null_unspecified)color;
		[Export ("setValueTextColor:")]
		void SetValueTextColor (UIColor color);

		// -(void)setValueFont:(UIFont * _Null_unspecified)font;
		[Export ("setValueFont:")]
		void SetValueFont (UIFont font);

		// -(void)setDrawValues:(BOOL)enabled;
		[Export ("setDrawValues:")]
		void SetDrawValues (bool enabled);

		// @property (nonatomic) BOOL highlightEnabled;
		[Export ("highlightEnabled")]
		bool HighlightEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightEnabled;
		[Export ("isHighlightEnabled")]
		bool IsHighlightEnabled { get; }

		// -(void)clearValues;
		[Export ("clearValues")]
		void ClearValues ();

		// -(BOOL)containsWithEntry:(ChartDataEntry * _Nonnull)entry;
		[Export ("containsWithEntry:")]
		bool ContainsWithEntry (ChartDataEntry entry);

		// -(BOOL)containsWithDataSet:(ChartDataSet * _Nonnull)dataSet;
		[Export ("containsWithDataSet:")]
		bool ContainsWithDataSet (ChartDataSet dataSet);

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull xValsObjc;
		[Export ("xValsObjc", ArgumentSemantic.Copy)]
		NSObject[] XValsObjc { get; }
	}


    #if false

	// @interface BarLineScatterCandleBubbleChartData : ChartData
	[BaseType (typeof(ChartData))]
	interface BarLineScatterCandleBubbleChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);
	}

	// @interface BarChartData : BarLineScatterCandleBubbleChartData
	[BaseType (typeof(BarLineScatterCandleBubbleChartData))]
	interface BarChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);

		// @property (nonatomic) CGFloat groupSpace;
		[Export ("groupSpace")]
		nfloat GroupSpace { get; set; }

		// @property (readonly, nonatomic) BOOL isGrouped;
		[Export ("isGrouped")]
		bool IsGrouped { get; }
	}

    #endif

	// @interface ChartDataEntry : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartDataEntry
	{
		// @property (nonatomic) double value;
		[Export ("value")]
		double Value { get; set; }

		// @property (nonatomic) NSInteger xIndex;
		[Export ("xIndex")]
		nint XIndex { get; set; }

		// @property (nonatomic) id _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Assign)]
		NSObject Data { get; set; }

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex __attribute__((objc_designated_initializer));
		//[Export ("initWithValue:xIndex:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (double value, nint xIndex);

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex data:(id _Nullable)data __attribute__((objc_designated_initializer));
		//[Export ("initWithValue:xIndex:data:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (double value, nint xIndex, [NullAllowed] NSObject data);

		// -(BOOL)isEqual:(id _Nullable)object;
		//[Export ("isEqual:")]
		//bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		//[Export ("description")]
		//string Description { get; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		//[Export ("copyWithZone:")]
        //unsafe NSObject CopyWithZone (NSZone* zone);
	}

    #if false
	// @interface BarChartDataEntry : ChartDataEntry
	[BaseType (typeof(ChartDataEntry))]
	interface BarChartDataEntry
	{
		// -(instancetype _Nonnull)initWithValues:(NSArray * _Nonnull)values xIndex:(NSInteger)xIndex __attribute__((objc_designated_initializer));
		[Export ("initWithValues:xIndex:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] values, nint xIndex);

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex __attribute__((objc_designated_initializer));
		[Export ("initWithValue:xIndex:")]
		[DesignatedInitializer]
		IntPtr Constructor (double value, nint xIndex);

		// -(instancetype _Nonnull)initWithValues:(NSArray * _Nonnull)values xIndex:(NSInteger)xIndex label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
		[Export ("initWithValues:xIndex:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] values, nint xIndex, string label);

		// -(instancetype _Nonnull)initWithValue:(double)value xIndex:(NSInteger)xIndex data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export ("initWithValue:xIndex:data:")]
		[DesignatedInitializer]
		IntPtr Constructor (double value, nint xIndex, [NullAllowed] NSObject data);

		// -(double)getBelowSum:(NSInteger)stackIndex;
		[Export ("getBelowSum:")]
		double GetBelowSum (nint stackIndex);

		// @property (readonly, nonatomic) double negativeSum;
		[Export ("negativeSum")]
		double NegativeSum { get; }

		// @property (readonly, nonatomic) double positiveSum;
		[Export ("positiveSum")]
		double PositiveSum { get; }

		// -(void)calcPosNegSum;
		[Export ("calcPosNegSum")]
		void CalcPosNegSum ();

		// @property (readonly, nonatomic) BOOL isStacked;
		[Export ("isStacked")]
		bool IsStacked { get; }

		// @property (copy, nonatomic) NSArray * _Nullable values;
		[NullAllowed, Export ("values", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Values { get; set; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);
	}
    #endif

	// @protocol ChartDataProvider
	[Protocol, Model]
	interface ChartDataProvider
	{
		// @required @property (readonly, nonatomic) double chartXMin;
		[Export ("chartXMin")]
		double ChartXMin { get; }

		// @required @property (readonly, nonatomic) double chartXMax;
		[Export ("chartXMax")]
		double ChartXMax { get; }

		// @required @property (readonly, nonatomic) double chartYMin;
		[Export ("chartYMin")]
		double ChartYMin { get; }

		// @required @property (readonly, nonatomic) double chartYMax;
		[Export ("chartYMax")]
		double ChartYMax { get; }

		// @required @property (readonly, nonatomic) NSInteger xValCount;
		[Export ("xValCount")]
		nint XValCount { get; }

		// @required @property (readonly, nonatomic) CGPoint centerOffsets;
		[Export ("centerOffsets")]
		CGPoint CenterOffsets { get; }

		// @required @property (readonly, nonatomic) ChartData * _Nullable data;
		[NullAllowed, Export ("data")]
		ChartData Data { get; }
	}

	// @protocol BarLineScatterCandleBubbleChartDataProvider <ChartDataProvider>
	[Protocol, Model]
	interface BarLineScatterCandleBubbleChartDataProvider : ChartDataProvider
	{
		// @required -(ChartTransformer * _Nonnull)getTransformer:(enum AxisDependency)which;
		[Abstract]
		[Export ("getTransformer:")]
		ChartTransformer GetTransformer (AxisDependency which);

		// @required @property (readonly, nonatomic) NSInteger maxVisibleValueCount;
		[Export ("maxVisibleValueCount")]
		nint MaxVisibleValueCount { get; }

		// @required -(BOOL)isInverted:(enum AxisDependency)axis;
		[Abstract]
		[Export ("isInverted:")]
		bool IsInverted (AxisDependency axis);

		// @required @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Export ("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @required @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Export ("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }
	}

    #if false
	// @protocol BarChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol, Model]
	interface BarChartDataProvider : IBarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic) BarChartData * _Nullable barData;
		[NullAllowed, Export ("barData")]
		BarChartData BarData { get; }

		// @required @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export ("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }

		// @required @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export ("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @required @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Export ("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }
	}
    #endif

	// @interface ChartDataSet : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartDataSet
	{
		// @property (copy, nonatomic) NSArray * _Nonnull colors;
		[Export ("colors", ArgumentSemantic.Copy)]
        UIColor[] Colors { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export ("label")]
		string Label { get; set; }

		// @property (nonatomic) BOOL visible;
		[Export ("visible")]
		bool Visible { get; set; }

		// @property (nonatomic) BOOL drawValuesEnabled;
		[Export ("drawValuesEnabled")]
		bool DrawValuesEnabled { get; set; }

		// @property (nonatomic) UIColor * _Nonnull valueTextColor;
		[Export ("valueTextColor", ArgumentSemantic.Assign)]
		UIColor ValueTextColor { get; set; }

		// @property (nonatomic) UIFont * _Nonnull valueFont;
		[Export ("valueFont", ArgumentSemantic.Assign)]
		UIFont ValueFont { get; set; }

		// @property (nonatomic) enum AxisDependency axisDependency;
		[Export ("axisDependency", ArgumentSemantic.Assign)]
		AxisDependency AxisDependency { get; set; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull yVals;
		[Export ("yVals", ArgumentSemantic.Copy)]
        ChartDataEntry[] YVals { get; }

		// @property (readonly, nonatomic) double yValueSum;
		[Export ("yValueSum")]
		double YValueSum { get; }

		// @property (readonly, nonatomic) double yMin;
		[Export ("yMin")]
		double YMin { get; }

		// @property (readonly, nonatomic) double yMax;
		[Export ("yMax")]
		double YMax { get; }

		// @property (nonatomic) BOOL highlightEnabled;
		[Export ("highlightEnabled")]
		bool HighlightEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightEnabled;
		[Export ("isHighlightEnabled")]
		bool IsHighlightEnabled { get; }

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		//[Export ("initWithYVals:label:")]
		//[DesignatedInitializer]
        //IntPtr Constructor ([NullAllowed] ChartDataEntry[] yVals, [NullAllowed] string label);

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals;
		//[Export ("initWithYVals:")]
        //IntPtr Constructor ([NullAllowed] ChartDataEntry[] yVals);

		// -(void)notifyDataSetChanged;
		[Export ("notifyDataSetChanged")]
		void NotifyDataSetChanged ();

		// @property (readonly, nonatomic) double average;
		[Export ("average")]
		double Average { get; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export ("entryCount")]
		nint EntryCount { get; }

		// -(double)yValForXIndex:(NSInteger)x;
		[Export ("yValForXIndex:")]
		double YValForXIndex (nint x);

		// -(ChartDataEntry * _Nullable)entryForXIndex:(NSInteger)x;
		[Export ("entryForXIndex:")]
		[return: NullAllowed]
		ChartDataEntry EntryForXIndex (nint x);

		// -(NSArray * _Nonnull)entriesForXIndex:(NSInteger)x;
		[Export ("entriesForXIndex:")]
        ChartDataEntry[] EntriesForXIndex (nint x);

		// -(NSInteger)entryIndexWithXIndex:(NSInteger)x;
		[Export ("entryIndexWithXIndex:")]
		nint EntryIndexWithXIndex (nint x);

		// -(NSInteger)entryIndexWithEntry:(ChartDataEntry * _Nonnull)e isEqual:(BOOL)isEqual;
		[Export ("entryIndexWithEntry:isEqual:")]
		nint EntryIndexWithEntry (ChartDataEntry e, bool isEqual);

		// @property (nonatomic) NSNumberFormatter * _Nullable valueFormatter;
		[NullAllowed, Export ("valueFormatter", ArgumentSemantic.Assign)]
		NSNumberFormatter ValueFormatter { get; set; }

		// @property (readonly, nonatomic) NSInteger valueCount;
		[Export ("valueCount")]
		nint ValueCount { get; }

		// -(void)addEntry:(ChartDataEntry * _Nonnull)e;
		[Export ("addEntry:")]
		void AddEntry (ChartDataEntry e);

		// -(void)addEntryOrdered:(ChartDataEntry * _Nonnull)e;
		[Export ("addEntryOrdered:")]
		void AddEntryOrdered (ChartDataEntry e);

		// -(BOOL)removeEntry:(ChartDataEntry * _Nonnull)entry;
		[Export ("removeEntry:")]
		bool RemoveEntry (ChartDataEntry entry);

		// -(BOOL)removeEntryWithXIndex:(NSInteger)xIndex;
		[Export ("removeEntryWithXIndex:")]
		bool RemoveEntryWithXIndex (nint xIndex);

		// -(BOOL)removeFirst;
		[Export ("removeFirst")]
		bool RemoveFirst { get; }

		// -(BOOL)removeLast;
		[Export ("removeLast")]
		bool RemoveLast { get; }

		// -(void)resetColors;
		[Export ("resetColors")]
		void ResetColors ();

		// -(void)addColor:(UIColor * _Nonnull)color;
		[Export ("addColor:")]
		void AddColor (UIColor color);

		// -(void)setColor:(UIColor * _Nonnull)color;
		[Export ("setColor:")]
		void SetColor (UIColor color);

		// -(UIColor * _Nonnull)colorAt:(NSInteger)index;
		[Export ("colorAt:")]
		UIColor ColorAt (nint index);

		// @property (readonly, nonatomic) BOOL isVisible;
		[Export ("isVisible")]
		bool IsVisible { get; }

		// @property (readonly, nonatomic) BOOL isDrawValuesEnabled;
		[Export ("isDrawValuesEnabled")]
		bool IsDrawValuesEnabled { get; }

		// -(BOOL)contains:(ChartDataEntry * _Nonnull)e;
		[Export ("contains:")]
		bool Contains (ChartDataEntry e);

		// -(void)clear;
		[Export ("clear")]
		void Clear ();

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		//[Export ("description")]
		//string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		//[Export ("debugDescription")]
		//string DebugDescription { get; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		//[Export ("copyWithZone:")]
		//unsafe NSObject CopyWithZone (NSZone* zone);
	}

	// @interface BarLineScatterCandleBubbleChartDataSet : ChartDataSet
	[BaseType (typeof(ChartDataSet))]
	interface BarLineScatterCandleBubbleChartDataSet
	{
		// @property (nonatomic) UIColor * _Nonnull highlightColor;
		[Export ("highlightColor", ArgumentSemantic.Assign)]
		UIColor HighlightColor { get; set; }

		// @property (nonatomic) CGFloat highlightLineWidth;
		[Export ("highlightLineWidth")]
		nfloat HighlightLineWidth { get; set; }

		// @property (nonatomic) CGFloat highlightLineDashPhase;
		[Export ("highlightLineDashPhase")]
		nfloat HighlightLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray * _Nullable highlightLineDashLengths;
		[NullAllowed, Export ("highlightLineDashLengths", ArgumentSemantic.Copy)]
        NSNumber[] HighlightLineDashLengths { get; set; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		//[Export ("copyWithZone:")]
		//unsafe NSObject CopyWithZone (NSZone* zone);

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		//[Export ("initWithYVals:label:")]
		//[DesignatedInitializer]
		//[Verify (StronglyTypedNSArray)]
		//IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);
	}

    #if false
	// @interface BarChartDataSet : BarLineScatterCandleBubbleChartDataSet
	[BaseType (typeof(BarLineScatterCandleBubbleChartDataSet))]
	interface BarChartDataSet
	{
		// @property (nonatomic) CGFloat barSpace;
		[Export ("barSpace")]
		nfloat BarSpace { get; set; }

		// @property (nonatomic) UIColor * _Nonnull barShadowColor;
		[Export ("barShadowColor", ArgumentSemantic.Assign)]
		UIColor BarShadowColor { get; set; }

		// @property (nonatomic) CGFloat highlightAlpha;
		[Export ("highlightAlpha")]
		nfloat HighlightAlpha { get; set; }

		// @property (copy, nonatomic) NSArray * _Nonnull stackLabels;
		[Export ("stackLabels", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] StackLabels { get; set; }

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);

		// @property (readonly, nonatomic) NSInteger stackSize;
		[Export ("stackSize")]
		nint StackSize { get; }

		// @property (readonly, nonatomic) BOOL isStacked;
		[Export ("isStacked")]
		bool IsStacked { get; }

		// @property (readonly, nonatomic) NSInteger entryCountStacks;
		[Export ("entryCountStacks")]
		nint EntryCountStacks { get; }
	}
    #endif

	// @interface ChartRendererBase : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartRendererBase
	{
		// @property (nonatomic) ChartViewPortHandler * _Null_unspecified viewPortHandler;
		[Export ("viewPortHandler", ArgumentSemantic.Assign)]
		ChartViewPortHandler ViewPortHandler { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler);

		// -(void)calcXBoundsWithChart:(BarLineChartViewBase * _Nonnull)chart xAxisModulus:(NSInteger)xAxisModulus;
		[Export ("calcXBoundsWithChart:xAxisModulus:")]
		void CalcXBoundsWithChart (BarLineChartViewBase chart, nint xAxisModulus);
	}

	// @interface ChartDataRendererBase : ChartRendererBase
	[BaseType (typeof(ChartRendererBase))]
	interface ChartDataRendererBase
	{
		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContext context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContext context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContext context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
        unsafe void DrawHighlightedWithContext (CGContext context, ChartHighlight[] indices);
	}

    #if false
	// @interface BarChartRenderer : ChartDataRendererBase
	[BaseType (typeof(ChartDataRendererBase))]
	interface BarChartRenderer
	{
		// @property (nonatomic, weak) id<BarChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export ("dataProvider", ArgumentSemantic.Weak)]
		BarChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] BarChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);
	}
    #endif

	// @protocol ChartAnimatorDelegate
	[Protocol, Model]
	interface ChartAnimatorDelegate
	{
		// @required -(void)chartAnimatorUpdated:(ChartAnimator * _Nonnull)chartAnimator;
		[Abstract]
		[Export ("chartAnimatorUpdated:")]
		void ChartAnimatorUpdated (ChartAnimator chartAnimator);

		// @required -(void)chartAnimatorStopped:(ChartAnimator * _Nonnull)chartAnimator;
		[Abstract]
		[Export ("chartAnimatorStopped:")]
		void ChartAnimatorStopped (ChartAnimator chartAnimator);
	}

	// @interface ChartViewBase : UIView <ChartDataProvider, ChartAnimatorDelegate>
	[BaseType (typeof(UIView))]
	interface ChartViewBase : ChartDataProvider, ChartAnimatorDelegate
	{
		// @property (nonatomic) BOOL dragDecelerationEnabled;
		[Export ("dragDecelerationEnabled")]
		bool DragDecelerationEnabled { get; set; }

		// @property (nonatomic) UIFont * _Nullable descriptionFont;
		[NullAllowed, Export ("descriptionFont", ArgumentSemantic.Assign)]
		UIFont DescriptionFont { get; set; }

		// @property (nonatomic) UIColor * _Nullable descriptionTextColor;
		[NullAllowed, Export ("descriptionTextColor", ArgumentSemantic.Assign)]
		UIColor DescriptionTextColor { get; set; }

		// @property (nonatomic) NSTextAlignment descriptionTextAlign;
		[Export ("descriptionTextAlign", ArgumentSemantic.Assign)]
        UITextAlignment DescriptionTextAlign { get; set; }

		// @property (nonatomic) UIFont * _Null_unspecified infoFont;
		[Export ("infoFont", ArgumentSemantic.Assign)]
		UIFont InfoFont { get; set; }

		// @property (nonatomic) UIColor * _Null_unspecified infoTextColor;
		[Export ("infoTextColor", ArgumentSemantic.Assign)]
		UIColor InfoTextColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull descriptionText;
		[Export ("descriptionText")]
		string DescriptionText { get; set; }

		//[Wrap ("WeakDelegate")]
		//[NullAllowed]
		//ChartViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ChartViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull noDataText;
		[Export ("noDataText")]
		string NoDataText { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable noDataTextDescription;
		[NullAllowed, Export ("noDataTextDescription")]
		string NoDataTextDescription { get; set; }

		// @property (nonatomic) ChartDataRendererBase * _Nullable renderer;
		[NullAllowed, Export ("renderer", ArgumentSemantic.Assign)]
		ChartDataRendererBase Renderer { get; set; }

		// @property (nonatomic) BOOL drawMarkers;
		[Export ("drawMarkers")]
		bool DrawMarkers { get; set; }

		// @property (nonatomic) ChartMarker * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Assign)]
		ChartMarker Marker { get; set; }

		// @property (nonatomic) CGFloat extraTopOffset;
		[Export ("extraTopOffset")]
		nfloat ExtraTopOffset { get; set; }

		// @property (nonatomic) CGFloat extraRightOffset;
		[Export ("extraRightOffset")]
		nfloat ExtraRightOffset { get; set; }

		// @property (nonatomic) CGFloat extraBottomOffset;
		[Export ("extraBottomOffset")]
		nfloat ExtraBottomOffset { get; set; }

		// @property (nonatomic) CGFloat extraLeftOffset;
		[Export ("extraLeftOffset")]
		nfloat ExtraLeftOffset { get; set; }

		// -(void)setExtraOffsetsWithLeft:(CGFloat)left top:(CGFloat)top right:(CGFloat)right bottom:(CGFloat)bottom;
		[Export ("setExtraOffsetsWithLeft:top:right:bottom:")]
		void SetExtraOffsetsWithLeft (nfloat left, nfloat top, nfloat right, nfloat bottom);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);

		// @property (nonatomic) ChartData * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Assign)]
		ChartData Data { get; set; }

		// -(void)clear;
		[Export ("clear")]
		void Clear ();

		// -(void)clearValues;
		[Export ("clearValues")]
		void ClearValues ();

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		bool IsEmpty { get; }

		// -(void)notifyDataSetChanged;
		[Export ("notifyDataSetChanged")]
		void NotifyDataSetChanged ();

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull highlighted;
		[Export ("highlighted", ArgumentSemantic.Copy)]
        ChartHighlight[] Highlighted { get; }

		// @property (nonatomic) BOOL highlightPerTapEnabled;
		[Export ("highlightPerTapEnabled")]
		bool HighlightPerTapEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighLightPerTapEnabled;
		[Export ("isHighLightPerTapEnabled")]
		bool IsHighLightPerTapEnabled { get; }

		// -(BOOL)valuesToHighlight;
		[Export ("valuesToHighlight")]
		bool ValuesToHighlight { get; }

		// -(void)highlightValues:(NSArray * _Nullable)highs;
		[Export ("highlightValues:")]
        void HighlightValues ([NullAllowed] ChartHighlight[] highs);

		// -(void)highlightValue:(ChartHighlight * _Nullable)highlight;
		[Export ("highlightValue:")]
		void HighlightValue ([NullAllowed] ChartHighlight highlight);

		// -(void)highlightValueWithXIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex callDelegate:(BOOL)callDelegate;
		[Export ("highlightValueWithXIndex:dataSetIndex:callDelegate:")]
		void HighlightValueWithXIndex (nint xIndex, nint dataSetIndex, bool callDelegate);

		// -(void)highlightValueWithHighlight:(ChartHighlight * _Nullable)highlight callDelegate:(BOOL)callDelegate;
		[Export ("highlightValueWithHighlight:callDelegate:")]
		void HighlightValueWithHighlight ([NullAllowed] ChartHighlight highlight, bool callDelegate);

		// @property (nonatomic) ChartHighlight * _Nullable lastHighlighted;
		[NullAllowed, Export ("lastHighlighted", ArgumentSemantic.Assign)]
		ChartHighlight LastHighlighted { get; set; }

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export ("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry (ChartDataEntry entry, ChartHighlight highlight);

		// @property (readonly, nonatomic) ChartAnimator * _Null_unspecified animator;
		[Export ("animator")]
		ChartAnimator Animator { get; }

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingX:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingX easingY:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingY;
		[Export ("animateWithXAxisDuration:yAxisDuration:easingX:easingY:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easingX, [NullAllowed] Func<double, double, nfloat> easingY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOptionX:(enum ChartEasingOption)easingOptionX easingOptionY:(enum ChartEasingOption)easingOptionY;
		[Export ("animateWithXAxisDuration:yAxisDuration:easingOptionX:easingOptionY:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, ChartEasingOption easingOptionX, ChartEasingOption easingOptionY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export ("animateWithXAxisDuration:yAxisDuration:easing:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export ("animateWithXAxisDuration:yAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export ("animateWithXAxisDuration:yAxisDuration:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export ("animateWithXAxisDuration:easing:")]
		void AnimateWithXAxisDuration (double xAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export ("animateWithXAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration (double xAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration;
		[Export ("animateWithXAxisDuration:")]
		void AnimateWithXAxisDuration (double xAxisDuration);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export ("animateWithYAxisDuration:easing:")]
		void AnimateWithYAxisDuration (double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export ("animateWithYAxisDuration:easingOption:")]
		void AnimateWithYAxisDuration (double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export ("animateWithYAxisDuration:")]
		void AnimateWithYAxisDuration (double yAxisDuration);

		// @property (readonly, nonatomic) double chartYMax;
		[Export ("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export ("chartYMin")]
		double ChartYMin { get; }

		// @property (readonly, nonatomic) double chartXMax;
		[Export ("chartXMax")]
		double ChartXMax { get; }

		// @property (readonly, nonatomic) double chartXMin;
		[Export ("chartXMin")]
		double ChartXMin { get; }

		// @property (readonly, nonatomic) NSInteger xValCount;
		[Export ("xValCount")]
		nint XValCount { get; }

		// @property (readonly, nonatomic) NSInteger valueCount;
		[Export ("valueCount")]
		nint ValueCount { get; }

		// @property (readonly, nonatomic) CGPoint midPoint;
		[Export ("midPoint")]
		CGPoint MidPoint { get; }

		// -(void)setDescriptionTextPositionWithX:(CGFloat)x y:(CGFloat)y;
		[Export ("setDescriptionTextPositionWithX:y:")]
		void SetDescriptionTextPositionWithX (nfloat x, nfloat y);

		// @property (readonly, nonatomic) CGPoint centerOffsets;
		[Export ("centerOffsets")]
		CGPoint CenterOffsets { get; }

		// @property (readonly, nonatomic) ChartLegend * _Nonnull legend;
		[Export ("legend")]
		ChartLegend Legend { get; }

		// @property (readonly, nonatomic) ChartLegendRenderer * _Null_unspecified legendRenderer;
		[Export ("legendRenderer")]
		ChartLegendRenderer LegendRenderer { get; }

		// @property (readonly, nonatomic) CGRect contentRect;
		[Export ("contentRect")]
		CGRect ContentRect { get; }

		// -(NSString * _Null_unspecified)getXValue:(NSInteger)index;
		[Export ("getXValue:")]
		string GetXValue (nint index);

		// -(NSArray * _Nonnull)getEntriesAtIndex:(NSInteger)xIndex;
		[Export ("getEntriesAtIndex:")]
        ChartDataEntry[] GetEntriesAtIndex (nint xIndex);

		// -(double)percentOfTotal:(double)val;
		[Export ("percentOfTotal:")]
		double PercentOfTotal (double val);

		// @property (readonly, nonatomic) ChartViewPortHandler * _Null_unspecified viewPortHandler;
		[Export ("viewPortHandler")]
		ChartViewPortHandler ViewPortHandler { get; }

		// -(UIImage * _Nonnull)getChartImageWithTransparent:(BOOL)transparent;
		[Export ("getChartImageWithTransparent:")]
		UIImage GetChartImageWithTransparent (bool transparent);

		// -(void)saveToCameraRoll;
		[Export ("saveToCameraRoll")]
		void SaveToCameraRoll ();

		// -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary * _Nullable)change context:(void * _Null_unspecified)context;
		//[Export ("observeValueForKeyPath:ofObject:change:context:")]
		//unsafe void ObserveValueForKeyPath ([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary change, void* context);

		// -(void)clearPendingViewPortChanges;
		[Export ("clearPendingViewPortChanges")]
		void ClearPendingViewPortChanges ();

		// @property (readonly, nonatomic) BOOL isDragDecelerationEnabled;
		[Export ("isDragDecelerationEnabled")]
		bool IsDragDecelerationEnabled { get; }

		// @property (nonatomic) CGFloat dragDecelerationFrictionCoef;
		[Export ("dragDecelerationFrictionCoef")]
		nfloat DragDecelerationFrictionCoef { get; set; }

		// -(void)chartAnimatorUpdated:(ChartAnimator * _Nonnull)chartAnimator;
		[Export ("chartAnimatorUpdated:")]
		void ChartAnimatorUpdated (ChartAnimator chartAnimator);

		// -(void)chartAnimatorStopped:(ChartAnimator * _Nonnull)chartAnimator;
		[Export ("chartAnimatorStopped:")]
		void ChartAnimatorStopped (ChartAnimator chartAnimator);

		// -(void)touchesBegan:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet touches, [NullAllowed] UIEvent @event);

		// -(void)touchesMoved:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesMoved:withEvent:")]
		void TouchesMoved (NSSet touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled ([NullAllowed] NSSet touches, [NullAllowed] UIEvent @event);
	}

	// @interface BarLineChartViewBase : ChartViewBase <BarLineScatterCandleBubbleChartDataProvider, UIGestureRecognizerDelegate>
	[BaseType (typeof(ChartViewBase))]
	interface BarLineChartViewBase : BarLineScatterCandleBubbleChartDataProvider, IUIGestureRecognizerDelegate
	{
		// @property (nonatomic) UIColor * _Nonnull gridBackgroundColor;
		[Export ("gridBackgroundColor", ArgumentSemantic.Assign)]
		UIColor GridBackgroundColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Assign)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) CGFloat borderLineWidth;
		[Export ("borderLineWidth")]
		nfloat BorderLineWidth { get; set; }

		// @property (nonatomic) BOOL drawGridBackgroundEnabled;
		[Export ("drawGridBackgroundEnabled")]
		bool DrawGridBackgroundEnabled { get; set; }

		// @property (nonatomic) BOOL drawBordersEnabled;
		[Export ("drawBordersEnabled")]
		bool DrawBordersEnabled { get; set; }

		// @property (nonatomic) CGFloat minOffset;
		[Export ("minOffset")]
		nfloat MinOffset { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export ("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);

		// -(void)notifyDataSetChanged;
		[Export ("notifyDataSetChanged")]
		void NotifyDataSetChanged ();

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)e highlight:(ChartHighlight * _Nonnull)highlight;
		[Export ("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry (ChartDataEntry e, ChartHighlight highlight);

		// -(void)stopDeceleration;
		[Export ("stopDeceleration")]
		void StopDeceleration ();

		// -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
		[Export ("gestureRecognizerShouldBegin:")]
		bool GestureRecognizerShouldBegin (UIGestureRecognizer gestureRecognizer);

		// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer;
		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);

		// -(void)zoomIn;
		[Export ("zoomIn")]
		void ZoomIn ();

		// -(void)zoomOut;
		[Export ("zoomOut")]
		void ZoomOut ();

		// -(void)zoom:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y;
		[Export ("zoom:scaleY:x:y:")]
		void Zoom (nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

		// -(void)fitScreen;
		[Export ("fitScreen")]
		void FitScreen ();

		// -(void)setScaleMinima:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export ("setScaleMinima:scaleY:")]
		void SetScaleMinima (nfloat scaleX, nfloat scaleY);

		// -(void)setVisibleXRangeMaximum:(CGFloat)maxXRange;
		[Export ("setVisibleXRangeMaximum:")]
		void SetVisibleXRangeMaximum (nfloat maxXRange);

		// -(void)setVisibleXRangeMinimum:(CGFloat)minXRange;
		[Export ("setVisibleXRangeMinimum:")]
		void SetVisibleXRangeMinimum (nfloat minXRange);

		// -(void)setVisibleXRangeWithMinXRange:(CGFloat)minXRange maxXRange:(CGFloat)maxXRange;
		[Export ("setVisibleXRangeWithMinXRange:maxXRange:")]
		void SetVisibleXRangeWithMinXRange (nfloat minXRange, nfloat maxXRange);

		// -(void)setVisibleYRangeMaximum:(CGFloat)maxYRange axis:(enum AxisDependency)axis;
		[Export ("setVisibleYRangeMaximum:axis:")]
		void SetVisibleYRangeMaximum (nfloat maxYRange, AxisDependency axis);

		// -(void)moveViewToX:(NSInteger)xIndex;
		[Export ("moveViewToX:")]
		void MoveViewToX (nint xIndex);

		// -(void)moveViewToY:(CGFloat)yValue axis:(enum AxisDependency)axis;
		[Export ("moveViewToY:axis:")]
		void MoveViewToY (nfloat yValue, AxisDependency axis);

		// -(void)moveViewToXIndex:(NSInteger)xIndex yValue:(CGFloat)yValue axis:(enum AxisDependency)axis;
		[Export ("moveViewToXIndex:yValue:axis:")]
		void MoveViewToXIndex (nint xIndex, nfloat yValue, AxisDependency axis);

		// -(void)centerViewToXIndex:(NSInteger)xIndex yValue:(CGFloat)yValue axis:(enum AxisDependency)axis;
		[Export ("centerViewToXIndex:yValue:axis:")]
		void CenterViewToXIndex (nint xIndex, nfloat yValue, AxisDependency axis);

		// -(void)setViewPortOffsetsWithLeft:(CGFloat)left top:(CGFloat)top right:(CGFloat)right bottom:(CGFloat)bottom;
		[Export ("setViewPortOffsetsWithLeft:top:right:bottom:")]
		void SetViewPortOffsetsWithLeft (nfloat left, nfloat top, nfloat right, nfloat bottom);

		// -(void)resetViewPortOffsets;
		[Export ("resetViewPortOffsets")]
		void ResetViewPortOffsets ();

		// -(CGFloat)getDeltaY:(enum AxisDependency)axis;
		[Export ("getDeltaY:")]
		nfloat GetDeltaY (AxisDependency axis);

		// -(CGPoint)getPosition:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis;
		[Export ("getPosition:axis:")]
		CGPoint GetPosition (ChartDataEntry e, AxisDependency axis);

		// @property (nonatomic) BOOL dragEnabled;
		[Export ("dragEnabled")]
		bool DragEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDragEnabled;
		[Export ("isDragEnabled")]
		bool IsDragEnabled { get; }

		// -(void)setScaleEnabled:(BOOL)enabled;
		[Export ("setScaleEnabled:")]
		void SetScaleEnabled (bool enabled);

		// @property (nonatomic) BOOL scaleXEnabled;
		[Export ("scaleXEnabled")]
		bool ScaleXEnabled { get; set; }

		// @property (nonatomic) BOOL scaleYEnabled;
		[Export ("scaleYEnabled")]
		bool ScaleYEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isScaleXEnabled;
		[Export ("isScaleXEnabled")]
		bool IsScaleXEnabled { get; }

		// @property (readonly, nonatomic) BOOL isScaleYEnabled;
		[Export ("isScaleYEnabled")]
		bool IsScaleYEnabled { get; }

		// @property (nonatomic) BOOL doubleTapToZoomEnabled;
		[Export ("doubleTapToZoomEnabled")]
		bool DoubleTapToZoomEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDoubleTapToZoomEnabled;
		[Export ("isDoubleTapToZoomEnabled")]
		bool IsDoubleTapToZoomEnabled { get; }

		// @property (nonatomic) BOOL highlightPerDragEnabled;
		[Export ("highlightPerDragEnabled")]
		bool HighlightPerDragEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHighlightPerDragEnabled;
		[Export ("isHighlightPerDragEnabled")]
		bool IsHighlightPerDragEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawGridBackgroundEnabled;
		[Export ("isDrawGridBackgroundEnabled")]
		bool IsDrawGridBackgroundEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBordersEnabled;
		[Export ("isDrawBordersEnabled")]
		bool IsDrawBordersEnabled { get; }

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export ("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint (CGPoint pt);

		// -(CGPoint)getValueByTouchPointWithPt:(CGPoint)pt axis:(enum AxisDependency)axis;
		[Export ("getValueByTouchPointWithPt:axis:")]
		CGPoint GetValueByTouchPointWithPt (CGPoint pt, AxisDependency axis);

		// -(CGPoint)getPixelForValue:(double)x y:(double)y axis:(enum AxisDependency)axis;
		[Export ("getPixelForValue:y:axis:")]
		CGPoint GetPixelForValue (double x, double y, AxisDependency axis);

		// -(CGFloat)getYValueByTouchPointWithPt:(CGPoint)pt axis:(enum AxisDependency)axis;
		[Export ("getYValueByTouchPointWithPt:axis:")]
		nfloat GetYValueByTouchPointWithPt (CGPoint pt, AxisDependency axis);

		// -(ChartDataEntry * _Null_unspecified)getEntryByTouchPoint:(CGPoint)pt;
		[Export ("getEntryByTouchPoint:")]
		ChartDataEntry GetEntryByTouchPoint (CGPoint pt);

		// -(BarLineScatterCandleBubbleChartDataSet * _Null_unspecified)getDataSetByTouchPoint:(CGPoint)pt;
		[Export ("getDataSetByTouchPoint:")]
		BarLineScatterCandleBubbleChartDataSet GetDataSetByTouchPoint (CGPoint pt);

		// @property (readonly, nonatomic) CGFloat scaleX;
		[Export ("scaleX")]
		nfloat ScaleX { get; }

		// @property (readonly, nonatomic) CGFloat scaleY;
		[Export ("scaleY")]
		nfloat ScaleY { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOut;
		[Export ("isFullyZoomedOut")]
		bool IsFullyZoomedOut { get; }

		// @property (readonly, nonatomic) ChartYAxis * _Nonnull leftAxis;
		[Export ("leftAxis")]
		ChartYAxis LeftAxis { get; }

		// @property (readonly, nonatomic) ChartYAxis * _Nonnull rightAxis;
		[Export ("rightAxis")]
		ChartYAxis RightAxis { get; }

		// -(ChartYAxis * _Nonnull)getAxis:(enum AxisDependency)axis;
		[Export ("getAxis:")]
		ChartYAxis GetAxis (AxisDependency axis);

		// @property (readonly, nonatomic) ChartXAxis * _Nonnull xAxis;
		[Export ("xAxis")]
		ChartXAxis XAxis { get; }

		// @property (nonatomic) BOOL pinchZoomEnabled;
		[Export ("pinchZoomEnabled")]
		bool PinchZoomEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isPinchZoomEnabled;
		[Export ("isPinchZoomEnabled")]
		bool IsPinchZoomEnabled { get; }

		// -(void)setDragOffsetX:(CGFloat)offset;
		[Export ("setDragOffsetX:")]
		void SetDragOffsetX (nfloat offset);

		// -(void)setDragOffsetY:(CGFloat)offset;
		[Export ("setDragOffsetY:")]
		void SetDragOffsetY (nfloat offset);

		// @property (readonly, nonatomic) BOOL hasNoDragOffset;
		[Export ("hasNoDragOffset")]
		bool HasNoDragOffset { get; }

		// @property (nonatomic) ChartXAxisRenderer * _Nonnull xAxisRenderer;
		[Export ("xAxisRenderer", ArgumentSemantic.Assign)]
		ChartXAxisRenderer XAxisRenderer { get; set; }

		// @property (nonatomic) ChartYAxisRenderer * _Nonnull leftYAxisRenderer;
		[Export ("leftYAxisRenderer", ArgumentSemantic.Assign)]
		ChartYAxisRenderer LeftYAxisRenderer { get; set; }

		// @property (nonatomic) ChartYAxisRenderer * _Nonnull rightYAxisRenderer;
		[Export ("rightYAxisRenderer", ArgumentSemantic.Assign)]
		ChartYAxisRenderer RightYAxisRenderer { get; set; }

		// @property (readonly, nonatomic) double chartYMax;
		[Export ("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export ("chartYMin")]
		double ChartYMin { get; }

		// @property (readonly, nonatomic) BOOL isAnyAxisInverted;
		[Export ("isAnyAxisInverted")]
		bool IsAnyAxisInverted { get; }

		// @property (nonatomic) BOOL autoScaleMinMaxEnabled;
		[Export ("autoScaleMinMaxEnabled")]
		bool AutoScaleMinMaxEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isAutoScaleMinMaxEnabled;
		[Export ("isAutoScaleMinMaxEnabled")]
		bool IsAutoScaleMinMaxEnabled { get; }

		// -(void)setYAxisMinWidth:(enum AxisDependency)which width:(CGFloat)width;
		[Export ("setYAxisMinWidth:width:")]
		void SetYAxisMinWidth (AxisDependency which, nfloat width);

		// -(CGFloat)getYAxisMinWidth:(enum AxisDependency)which;
		[Export ("getYAxisMinWidth:")]
		nfloat GetYAxisMinWidth (AxisDependency which);

		// -(void)setYAxisMaxWidth:(enum AxisDependency)which width:(CGFloat)width;
		[Export ("setYAxisMaxWidth:width:")]
		void SetYAxisMaxWidth (AxisDependency which, nfloat width);

		// -(CGFloat)getYAxisMaxWidth:(enum AxisDependency)which;
		[Export ("getYAxisMaxWidth:")]
		nfloat GetYAxisMaxWidth (AxisDependency which);

		// -(CGFloat)getYAxisWidth:(enum AxisDependency)which;
		[Export ("getYAxisWidth:")]
		nfloat GetYAxisWidth (AxisDependency which);

		// -(ChartTransformer * _Nonnull)getTransformer:(enum AxisDependency)which;
		[Export ("getTransformer:")]
		ChartTransformer GetTransformer (AxisDependency which);

		// @property (nonatomic) NSInteger maxVisibleValueCount;
		[Export ("maxVisibleValueCount")]
		nint MaxVisibleValueCount { get; set; }

		// -(BOOL)isInverted:(enum AxisDependency)axis;
		[Export ("isInverted:")]
		bool IsInverted (AxisDependency axis);

		// @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Export ("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Export ("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }
	}

    #if false
	// @interface BarChartView : BarLineChartViewBase <BarChartDataProvider>
	[BaseType (typeof(BarLineChartViewBase))]
	interface BarChartView : IBarChartDataProvider
	{
		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export ("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint (CGPoint pt);

		// @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Export ("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Export ("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }

		// @property (nonatomic) BOOL drawHighlightArrowEnabled;
		[Export ("drawHighlightArrowEnabled")]
		bool DrawHighlightArrowEnabled { get; set; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export ("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export ("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// @property (readonly, nonatomic) BarChartData * _Nullable barData;
		[NullAllowed, Export ("barData")]
		BarChartData BarData { get; }

		// @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Export ("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export ("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export ("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface BubbleChartData : BarLineScatterCandleBubbleChartData
	[BaseType (typeof(BarLineScatterCandleBubbleChartData))]
	interface BubbleChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);

		// -(void)setHighlightCircleWidth:(CGFloat)width;
		[Export ("setHighlightCircleWidth:")]
		void SetHighlightCircleWidth (nfloat width);
	}

	// @interface BubbleChartDataEntry : ChartDataEntry
	[BaseType (typeof(ChartDataEntry))]
	interface BubbleChartDataEntry
	{
		// @property (nonatomic) CGFloat size;
		[Export ("size")]
		nfloat Size { get; set; }

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex value:(double)value size:(CGFloat)size __attribute__((objc_designated_initializer));
		[Export ("initWithXIndex:value:size:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint xIndex, double value, nfloat size);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex value:(double)value size:(CGFloat)size data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export ("initWithXIndex:value:size:data:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint xIndex, double value, nfloat size, [NullAllowed] NSObject data);

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);
	}

	// @protocol BubbleChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol, Model]
	interface BubbleChartDataProvider : IBarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic) BubbleChartData * _Nullable bubbleData;
		[NullAllowed, Export ("bubbleData")]
		BubbleChartData BubbleData { get; }
	}

	// @interface BubbleChartDataSet : BarLineScatterCandleBubbleChartDataSet
	[BaseType (typeof(BarLineScatterCandleBubbleChartDataSet))]
	interface BubbleChartDataSet
	{
		// @property (readonly, nonatomic) double xMin;
		[Export ("xMin")]
		double XMin { get; }

		// @property (readonly, nonatomic) double xMax;
		[Export ("xMax")]
		double XMax { get; }

		// @property (readonly, nonatomic) CGFloat maxSize;
		[Export ("maxSize")]
		nfloat MaxSize { get; }

		// -(void)setColor:(UIColor * _Nonnull)color alpha:(CGFloat)alpha;
		[Export ("setColor:alpha:")]
		void SetColor (UIColor color, nfloat alpha);

		// @property (nonatomic) CGFloat highlightCircleWidth;
		[Export ("highlightCircleWidth")]
		nfloat HighlightCircleWidth { get; set; }

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);
	}

	// @interface BubbleChartRenderer : ChartDataRendererBase
	[BaseType (typeof(ChartDataRendererBase))]
	interface BubbleChartRenderer
	{
		// @property (nonatomic, weak) id<BubbleChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export ("dataProvider", ArgumentSemantic.Weak)]
		BubbleChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<BubbleChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] BubbleChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);
	}

	// @interface BubbleChartView : BarLineChartViewBase <BubbleChartDataProvider>
	[BaseType (typeof(BarLineChartViewBase))]
	interface BubbleChartView : IBubbleChartDataProvider
	{
		// -(void)initialize;
		[Export ("initialize")]
		void Initialize ();

		// -(void)calcMinMax;
		[Export ("calcMinMax")]
		void CalcMinMax ();

		// @property (readonly, nonatomic) BubbleChartData * _Nullable bubbleData;
		[NullAllowed, Export ("bubbleData")]
		BubbleChartData BubbleData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface CandleChartData : BarLineScatterCandleBubbleChartData
	[BaseType (typeof(BarLineScatterCandleBubbleChartData))]
	interface CandleChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);
	}

	// @interface CandleChartDataEntry : ChartDataEntry
	[BaseType (typeof(ChartDataEntry))]
	interface CandleChartDataEntry
	{
		// @property (nonatomic) double high;
		[Export ("high")]
		double High { get; set; }

		// @property (nonatomic) double low;
		[Export ("low")]
		double Low { get; set; }

		// @property (nonatomic) double close;
		[Export ("close")]
		double Close { get; set; }

		// @property (nonatomic) double open;
		[Export ("open")]
		double Open { get; set; }

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close __attribute__((objc_designated_initializer));
		[Export ("initWithXIndex:shadowH:shadowL:open:close:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint xIndex, double shadowH, double shadowL, double open, double close);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)xIndex shadowH:(double)shadowH shadowL:(double)shadowL open:(double)open close:(double)close data:(id _Nullable)data __attribute__((objc_designated_initializer));
		[Export ("initWithXIndex:shadowH:shadowL:open:close:data:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint xIndex, double shadowH, double shadowL, double open, double close, [NullAllowed] NSObject data);

		// @property (readonly, nonatomic) double shadowRange;
		[Export ("shadowRange")]
		double ShadowRange { get; }

		// @property (readonly, nonatomic) double bodyRange;
		[Export ("bodyRange")]
		double BodyRange { get; }

		// @property (nonatomic) double value;
		[Export ("value")]
		double Value { get; set; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);
	}

	// @protocol CandleChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol, Model]
	interface CandleChartDataProvider : IBarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic) CandleChartData * _Nullable candleData;
		[NullAllowed, Export ("candleData")]
		CandleChartData CandleData { get; }
	}

	// @interface LineScatterCandleChartDataSet : BarLineScatterCandleBubbleChartDataSet
	[BaseType (typeof(BarLineScatterCandleBubbleChartDataSet))]
	interface LineScatterCandleChartDataSet
	{
		// @property (nonatomic) BOOL drawHorizontalHighlightIndicatorEnabled;
		[Export ("drawHorizontalHighlightIndicatorEnabled")]
		bool DrawHorizontalHighlightIndicatorEnabled { get; set; }

		// @property (nonatomic) BOOL drawVerticalHighlightIndicatorEnabled;
		[Export ("drawVerticalHighlightIndicatorEnabled")]
		bool DrawVerticalHighlightIndicatorEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isHorizontalHighlightIndicatorEnabled;
		[Export ("isHorizontalHighlightIndicatorEnabled")]
		bool IsHorizontalHighlightIndicatorEnabled { get; }

		// @property (readonly, nonatomic) BOOL isVerticalHighlightIndicatorEnabled;
		[Export ("isVerticalHighlightIndicatorEnabled")]
		bool IsVerticalHighlightIndicatorEnabled { get; }

		// -(void)setDrawHighlightIndicators:(BOOL)enabled;
		[Export ("setDrawHighlightIndicators:")]
		void SetDrawHighlightIndicators (bool enabled);

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);
	}

	// @interface CandleChartDataSet : LineScatterCandleChartDataSet
	[BaseType (typeof(LineScatterCandleChartDataSet))]
	interface CandleChartDataSet
	{
		// @property (nonatomic) CGFloat shadowWidth;
		[Export ("shadowWidth")]
		nfloat ShadowWidth { get; set; }

		// @property (nonatomic) UIColor * _Nullable shadowColor;
		[NullAllowed, Export ("shadowColor", ArgumentSemantic.Assign)]
		UIColor ShadowColor { get; set; }

		// @property (nonatomic) BOOL shadowColorSameAsCandle;
		[Export ("shadowColorSameAsCandle")]
		bool ShadowColorSameAsCandle { get; set; }

		// @property (nonatomic) UIColor * _Nullable decreasingColor;
		[NullAllowed, Export ("decreasingColor", ArgumentSemantic.Assign)]
		UIColor DecreasingColor { get; set; }

		// @property (nonatomic) UIColor * _Nullable increasingColor;
		[NullAllowed, Export ("increasingColor", ArgumentSemantic.Assign)]
		UIColor IncreasingColor { get; set; }

		// @property (nonatomic) BOOL decreasingFilled;
		[Export ("decreasingFilled")]
		bool DecreasingFilled { get; set; }

		// @property (nonatomic) BOOL increasingFilled;
		[Export ("increasingFilled")]
		bool IncreasingFilled { get; set; }

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);

		// @property (nonatomic) CGFloat bodySpace;
		[Export ("bodySpace")]
		nfloat BodySpace { get; set; }

		// @property (readonly, nonatomic) BOOL isShadowColorSameAsCandle;
		[Export ("isShadowColorSameAsCandle")]
		bool IsShadowColorSameAsCandle { get; }

		// @property (readonly, nonatomic) BOOL isIncreasingFilled;
		[Export ("isIncreasingFilled")]
		bool IsIncreasingFilled { get; }

		// @property (readonly, nonatomic) BOOL isDecreasingFilled;
		[Export ("isDecreasingFilled")]
		bool IsDecreasingFilled { get; }
	}

	// @interface LineScatterCandleRadarChartRenderer : ChartDataRendererBase
	[BaseType (typeof(ChartDataRendererBase))]
	interface LineScatterCandleRadarChartRenderer
	{
		// -(instancetype _Nonnull)initWithAnimator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithAnimator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawHighlightLinesWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point set:(LineScatterCandleChartDataSet * _Nonnull)set;
		[Export ("drawHighlightLinesWithContext:point:set:")]
		unsafe void DrawHighlightLinesWithContext (CGContextRef* context, CGPoint point, LineScatterCandleChartDataSet set);
	}

	// @interface CandleStickChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType (typeof(LineScatterCandleRadarChartRenderer))]
	interface CandleStickChartRenderer
	{
		// @property (nonatomic, weak) id<CandleChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export ("dataProvider", ArgumentSemantic.Weak)]
		CandleChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<CandleChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] CandleChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);
	}

	// @interface CandleStickChartView : BarLineChartViewBase <CandleChartDataProvider>
	[BaseType (typeof(BarLineChartViewBase))]
	interface CandleStickChartView : ICandleChartDataProvider
	{
		// @property (readonly, nonatomic) CandleChartData * _Nullable candleData;
		[NullAllowed, Export ("candleData")]
		CandleChartData CandleData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}
    #endif

	// @interface ChartAnimator : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartAnimator
	{
		//[Wrap ("WeakDelegate")]
		//[NullAllowed]
		//ChartAnimatorDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ChartAnimatorDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) updateBlock;
		[NullAllowed, Export ("updateBlock", ArgumentSemantic.Copy)]
		Action UpdateBlock { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) stopBlock;
		[NullAllowed, Export ("stopBlock", ArgumentSemantic.Copy)]
		Action StopBlock { get; set; }

		// @property (nonatomic) CGFloat phaseX;
		[Export ("phaseX")]
		nfloat PhaseX { get; set; }

		// @property (nonatomic) CGFloat phaseY;
		[Export ("phaseY")]
		nfloat PhaseY { get; set; }

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingX:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingX easingY:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easingY;
		[Export ("animateWithXAxisDuration:yAxisDuration:easingX:easingY:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easingX, [NullAllowed] Func<double, double, nfloat> easingY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOptionX:(enum ChartEasingOption)easingOptionX easingOptionY:(enum ChartEasingOption)easingOptionY;
		[Export ("animateWithXAxisDuration:yAxisDuration:easingOptionX:easingOptionY:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, ChartEasingOption easingOptionX, ChartEasingOption easingOptionY);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export ("animateWithXAxisDuration:yAxisDuration:easing:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export ("animateWithXAxisDuration:yAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration yAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export ("animateWithXAxisDuration:yAxisDuration:")]
		void AnimateWithXAxisDuration (double xAxisDuration, double yAxisDuration);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export ("animateWithXAxisDuration:easing:")]
		void AnimateWithXAxisDuration (double xAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export ("animateWithXAxisDuration:easingOption:")]
		void AnimateWithXAxisDuration (double xAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithXAxisDuration:(NSTimeInterval)xAxisDuration;
		[Export ("animateWithXAxisDuration:")]
		void AnimateWithXAxisDuration (double xAxisDuration);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export ("animateWithYAxisDuration:easing:")]
		void AnimateWithYAxisDuration (double yAxisDuration, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration easingOption:(enum ChartEasingOption)easingOption;
		[Export ("animateWithYAxisDuration:easingOption:")]
		void AnimateWithYAxisDuration (double yAxisDuration, ChartEasingOption easingOption);

		// -(void)animateWithYAxisDuration:(NSTimeInterval)yAxisDuration;
		[Export ("animateWithYAxisDuration:")]
		void AnimateWithYAxisDuration (double yAxisDuration);
	}

	// @interface ChartComponentBase : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartComponentBase
	{
		// @property (nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (nonatomic) CGFloat xOffset;
		[Export ("xOffset")]
		nfloat XOffset { get; set; }

		// @property (nonatomic) CGFloat yOffset;
		[Export ("yOffset")]
		nfloat YOffset { get; set; }

		// @property (readonly, nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; }
	}

	// @interface ChartAxisBase : ChartComponentBase
	[BaseType (typeof(ChartComponentBase))]
	interface ChartAxisBase
	{
		// @property (nonatomic) UIFont * _Nonnull labelFont;
		[Export ("labelFont", ArgumentSemantic.Assign)]
		UIFont LabelFont { get; set; }

		// @property (nonatomic) UIColor * _Nonnull labelTextColor;
		[Export ("labelTextColor", ArgumentSemantic.Assign)]
		UIColor LabelTextColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull axisLineColor;
		[Export ("axisLineColor", ArgumentSemantic.Assign)]
		UIColor AxisLineColor { get; set; }

		// @property (nonatomic) CGFloat axisLineWidth;
		[Export ("axisLineWidth")]
		nfloat AxisLineWidth { get; set; }

		// @property (nonatomic) CGFloat axisLineDashPhase;
		[Export ("axisLineDashPhase")]
		nfloat AxisLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray * _Null_unspecified axisLineDashLengths;
		[Export ("axisLineDashLengths", ArgumentSemantic.Copy)]
        NSNumber[] AxisLineDashLengths { get; set; }

		// @property (nonatomic) UIColor * _Nonnull gridColor;
		[Export ("gridColor", ArgumentSemantic.Assign)]
		UIColor GridColor { get; set; }

		// @property (nonatomic) CGFloat gridLineWidth;
		[Export ("gridLineWidth")]
		nfloat GridLineWidth { get; set; }

		// @property (nonatomic) CGFloat gridLineDashPhase;
		[Export ("gridLineDashPhase")]
		nfloat GridLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray * _Null_unspecified gridLineDashLengths;
		[Export ("gridLineDashLengths", ArgumentSemantic.Copy)]
        NSNumber[] GridLineDashLengths { get; set; }

		// @property (nonatomic) BOOL drawGridLinesEnabled;
		[Export ("drawGridLinesEnabled")]
		bool DrawGridLinesEnabled { get; set; }

		// @property (nonatomic) BOOL drawAxisLineEnabled;
		[Export ("drawAxisLineEnabled")]
		bool DrawAxisLineEnabled { get; set; }

		// @property (nonatomic) BOOL drawLabelsEnabled;
		[Export ("drawLabelsEnabled")]
		bool DrawLabelsEnabled { get; set; }

		// @property (nonatomic) BOOL drawLimitLinesBehindDataEnabled;
		[Export ("drawLimitLinesBehindDataEnabled")]
		bool DrawLimitLinesBehindDataEnabled { get; set; }

		// @property (nonatomic) BOOL gridAntialiasEnabled;
		[Export ("gridAntialiasEnabled")]
		bool GridAntialiasEnabled { get; set; }

		// -(NSString * _Nonnull)getLongestLabel;
		[Export ("getLongestLabel")]
		string LongestLabel { get; }

		// @property (readonly, nonatomic) BOOL isDrawGridLinesEnabled;
		[Export ("isDrawGridLinesEnabled")]
		bool IsDrawGridLinesEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawAxisLineEnabled;
		[Export ("isDrawAxisLineEnabled")]
		bool IsDrawAxisLineEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawLabelsEnabled;
		[Export ("isDrawLabelsEnabled")]
		bool IsDrawLabelsEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawLimitLinesBehindDataEnabled;
		[Export ("isDrawLimitLinesBehindDataEnabled")]
		bool IsDrawLimitLinesBehindDataEnabled { get; }

		// -(void)addLimitLine:(ChartLimitLine * _Nonnull)line;
		[Export ("addLimitLine:")]
		void AddLimitLine (ChartLimitLine line);

		// -(void)removeLimitLine:(ChartLimitLine * _Nonnull)line;
		[Export ("removeLimitLine:")]
		void RemoveLimitLine (ChartLimitLine line);

		// -(void)removeAllLimitLines;
		[Export ("removeAllLimitLines")]
		void RemoveAllLimitLines ();

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull limitLines;
		[Export ("limitLines", ArgumentSemantic.Copy)]
        ChartLimitLine[] LimitLines { get; }
	}

	// @interface ChartAxisRendererBase : ChartRendererBase
	[BaseType (typeof(ChartRendererBase))]
	interface ChartAxisRendererBase
	{
		// @property (nonatomic) ChartTransformer * _Null_unspecified transformer;
		[Export ("transformer", ArgumentSemantic.Assign)]
		ChartTransformer Transformer { get; set; }

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartTransformer transformer);

		// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLabelsWithContext:")]
		unsafe void RenderAxisLabelsWithContext (CGContext context);

		// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderGridLinesWithContext:")]
		unsafe void RenderGridLinesWithContext (CGContext context);

		// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLineWithContext:")]
		unsafe void RenderAxisLineWithContext (CGContext context);

		// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLimitLinesWithContext:")]
		unsafe void RenderLimitLinesWithContext (CGContext context);
	}

    #if false
	// @interface ChartColorTemplates : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartColorTemplates
	{
		// +(NSArray * _Nonnull)liberty;
		[Static]
		[Export ("liberty")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Liberty { get; }

		// +(NSArray * _Nonnull)joyful;
		[Static]
		[Export ("joyful")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Joyful { get; }

		// +(NSArray * _Nonnull)pastel;
		[Static]
		[Export ("pastel")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Pastel { get; }

		// +(NSArray * _Nonnull)colorful;
		[Static]
		[Export ("colorful")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Colorful { get; }

		// +(NSArray * _Nonnull)vordiplom;
		[Static]
		[Export ("vordiplom")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Vordiplom { get; }
	}

	// @interface ChartDataBaseFilter : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartDataBaseFilter
	{
		// -(NSArray * _Nonnull)filter:(NSArray * _Nonnull)points;
		[Export ("filter:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] Filter (NSObject[] points);
	}

	// @interface ChartDataApproximatorFilter : ChartDataBaseFilter
	[BaseType (typeof(ChartDataBaseFilter))]
	interface ChartDataApproximatorFilter
	{
		// @property (nonatomic) enum ApproximatorType type;
		[Export ("type", ArgumentSemantic.Assign)]
		ApproximatorType Type { get; set; }

		// @property (nonatomic) double tolerance;
		[Export ("tolerance")]
		double Tolerance { get; set; }

		// @property (nonatomic) double scaleRatio;
		[Export ("scaleRatio")]
		double ScaleRatio { get; set; }

		// @property (nonatomic) double deltaRatio;
		[Export ("deltaRatio")]
		double DeltaRatio { get; set; }

		// -(instancetype _Nonnull)initWithType:(enum ApproximatorType)type tolerance:(double)tolerance __attribute__((objc_designated_initializer));
		[Export ("initWithType:tolerance:")]
		[DesignatedInitializer]
		IntPtr Constructor (ApproximatorType type, double tolerance);

		// -(void)setup:(enum ApproximatorType)type tolerance:(double)tolerance;
		[Export ("setup:tolerance:")]
		void Setup (ApproximatorType type, double tolerance);

		// -(void)setRatios:(double)deltaRatio scaleRatio:(double)scaleRatio;
		[Export ("setRatios:scaleRatio:")]
		void SetRatios (double deltaRatio, double scaleRatio);

		// -(NSArray * _Nonnull)filter:(NSArray * _Nonnull)points;
		[Export ("filter:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] Filter (NSObject[] points);

		// -(NSArray * _Nonnull)filter:(NSArray * _Nonnull)points tolerance:(double)tolerance;
		[Export ("filter:tolerance:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] Filter (NSObject[] points, double tolerance);
	}
    #endif

	// @protocol ChartXAxisValueFormatter
	//[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface ChartXAxisValueFormatter
	{
		// @required -(NSString * _Nonnull)stringForXValue:(NSInteger)index original:(NSString * _Nonnull)original viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler;
		[Abstract]
		[Export ("stringForXValue:original:viewPortHandler:")]
		string Original (nint index, string original, ChartViewPortHandler viewPortHandler);
	}

    #if false
	// @interface ChartDefaultXAxisValueFormatter : NSObject <ChartXAxisValueFormatter>
	[BaseType (typeof(NSObject))]
	interface ChartDefaultXAxisValueFormatter : IChartXAxisValueFormatter
	{
		// -(NSString * _Nonnull)stringForXValue:(NSInteger)index original:(NSString * _Nonnull)original viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler;
		[Export ("stringForXValue:original:viewPortHandler:")]
		string StringForXValue (nint index, string original, ChartViewPortHandler viewPortHandler);
	}

	// @protocol ChartFillFormatter
	[Protocol, Model]
	interface ChartFillFormatter
	{
		// @required -(CGFloat)getFillLinePositionWithDataSet:(LineChartDataSet * _Nonnull)dataSet dataProvider:(id<LineChartDataProvider> _Nonnull)dataProvider;
		[Abstract]
		[Export ("getFillLinePositionWithDataSet:dataProvider:")]
		nfloat DataProvider (LineChartDataSet dataSet, LineChartDataProvider dataProvider);
	}
    #endif

	// @interface ChartHighlight : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartHighlight
	{
		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x dataSetIndex:(NSInteger)dataSetIndex __attribute__((objc_designated_initializer));
		[Export ("initWithXIndex:dataSetIndex:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint x, nint dataSetIndex);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex __attribute__((objc_designated_initializer));
		[Export ("initWithXIndex:dataSetIndex:stackIndex:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint x, nint dataSetIndex, nint stackIndex);

		// -(instancetype _Nonnull)initWithXIndex:(NSInteger)x dataSetIndex:(NSInteger)dataSetIndex stackIndex:(NSInteger)stackIndex range:(ChartRange * _Nonnull)range;
		[Export ("initWithXIndex:dataSetIndex:stackIndex:range:")]
		IntPtr Constructor (nint x, nint dataSetIndex, nint stackIndex, ChartRange range);

		// @property (readonly, nonatomic) NSInteger dataSetIndex;
		[Export ("dataSetIndex")]
		nint DataSetIndex { get; }

		// @property (readonly, nonatomic) NSInteger xIndex;
		[Export ("xIndex")]
		nint XIndex { get; }

		// @property (readonly, nonatomic) NSInteger stackIndex;
		[Export ("stackIndex")]
		nint StackIndex { get; }

		// @property (readonly, nonatomic) ChartRange * _Nullable range;
		[NullAllowed, Export ("range")]
		ChartRange Range { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		//[Export ("description")]
		//string Description { get; }

		// -(BOOL)isEqual:(id _Nullable)object;
		//[Export ("isEqual:")]
		//bool IsEqual ([NullAllowed] NSObject @object);
	}

	// @interface ChartLegend : ChartComponentBase
	[BaseType (typeof(ChartComponentBase))]
	interface ChartLegend
	{
		// @property (nonatomic) enum ChartLegendPosition position;
		[Export ("position", ArgumentSemantic.Assign)]
		ChartLegendPosition Position { get; set; }

		// @property (nonatomic) enum ChartLegendDirection direction;
		[Export ("direction", ArgumentSemantic.Assign)]
		ChartLegendDirection Direction { get; set; }

		// @property (nonatomic) UIFont * _Nonnull font;
		[Export ("font", ArgumentSemantic.Assign)]
		UIFont Font { get; set; }

		// @property (nonatomic) UIColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }

		// @property (nonatomic) enum ChartLegendForm form;
		[Export ("form", ArgumentSemantic.Assign)]
		ChartLegendForm Form { get; set; }

		// @property (nonatomic) CGFloat formSize;
		[Export ("formSize")]
		nfloat FormSize { get; set; }

		// @property (nonatomic) CGFloat formLineWidth;
		[Export ("formLineWidth")]
		nfloat FormLineWidth { get; set; }

		// @property (nonatomic) CGFloat xEntrySpace;
		[Export ("xEntrySpace")]
		nfloat XEntrySpace { get; set; }

		// @property (nonatomic) CGFloat yEntrySpace;
		[Export ("yEntrySpace")]
		nfloat YEntrySpace { get; set; }

		// @property (nonatomic) CGFloat formToTextSpace;
		[Export ("formToTextSpace")]
		nfloat FormToTextSpace { get; set; }

		// @property (nonatomic) CGFloat stackSpace;
		[Export ("stackSpace")]
		nfloat StackSpace { get; set; }

		// @property (copy, nonatomic) NSArray * _Nonnull calculatedLabelBreakPoints;
		[Export ("calculatedLabelBreakPoints", ArgumentSemantic.Copy)]
        NSNumber[] CalculatedLabelBreakPoints { get; set; }

		// -(instancetype _Nonnull)initWithColors:(NSArray * _Nonnull)colors labels:(NSArray * _Nonnull)labels __attribute__((objc_designated_initializer));
		//[Export ("initWithColors:labels:")]
		//[DesignatedInitializer]
		//[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		//IntPtr Constructor (NSObject[] colors, NSObject[] labels);

		// -(CGSize)getMaximumEntrySize:(UIFont * _Nonnull)font;
		[Export ("getMaximumEntrySize:")]
		CGSize GetMaximumEntrySize (UIFont font);

		// -(NSString * _Nullable)getLabel:(NSInteger)index;
		[Export ("getLabel:")]
		[return: NullAllowed]
		string GetLabel (nint index);

		// -(CGSize)getFullSize:(UIFont * _Nonnull)labelFont;
		[Export ("getFullSize:")]
		CGSize GetFullSize (UIFont labelFont);

		// @property (nonatomic) CGFloat neededWidth;
		[Export ("neededWidth")]
		nfloat NeededWidth { get; set; }

		// @property (nonatomic) CGFloat neededHeight;
		[Export ("neededHeight")]
		nfloat NeededHeight { get; set; }

		// @property (nonatomic) CGFloat textWidthMax;
		[Export ("textWidthMax")]
		nfloat TextWidthMax { get; set; }

		// @property (nonatomic) CGFloat textHeightMax;
		[Export ("textHeightMax")]
		nfloat TextHeightMax { get; set; }

		// @property (nonatomic) BOOL wordWrapEnabled;
		[Export ("wordWrapEnabled")]
		bool WordWrapEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isWordWrapEnabled;
		[Export ("isWordWrapEnabled")]
		bool IsWordWrapEnabled { get; }

		// @property (nonatomic) CGFloat maxSizePercent;
		[Export ("maxSizePercent")]
		nfloat MaxSizePercent { get; set; }

		// -(void)calculateDimensionsWithLabelFont:(UIFont * _Nonnull)labelFont viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler;
		[Export ("calculateDimensionsWithLabelFont:viewPortHandler:")]
		void CalculateDimensionsWithLabelFont (UIFont labelFont, ChartViewPortHandler viewPortHandler);

		// -(void)resetCustom;
		[Export ("resetCustom")]
		void ResetCustom ();

		// @property (readonly, nonatomic) BOOL isLegendCustom;
		[Export ("isLegendCustom")]
		bool IsLegendCustom { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull extraColorsObjc;
		[Export ("extraColorsObjc", ArgumentSemantic.Copy)]
		NSObject[] ExtraColorsObjc { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull extraLabelsObjc;
		[Export ("extraLabelsObjc", ArgumentSemantic.Copy)]
		NSObject[] ExtraLabelsObjc { get; }

		// @property (copy, nonatomic) NSArray * _Nonnull colorsObjc;
		[Export ("colorsObjc", ArgumentSemantic.Copy)]
		NSObject[] ColorsObjc { get; set; }

		// @property (copy, nonatomic) NSArray * _Nonnull labelsObjc;
		[Export ("labelsObjc", ArgumentSemantic.Copy)]
		NSObject[] LabelsObjc { get; set; }

		// -(void)setExtraWithColors:(NSArray * _Nonnull)colors labels:(NSArray * _Nonnull)labels;
		[Export ("setExtraWithColors:labels:")]
		void SetExtraWithColors (NSObject[] colors, NSObject[] labels);

		// -(void)setCustomWithColors:(NSArray * _Nonnull)colors labels:(NSArray * _Nonnull)labels;
		[Export ("setCustomWithColors:labels:")]
		void SetCustomWithColors (NSObject[] colors, NSObject[] labels);
	}

	// @interface ChartLegendRenderer : ChartRendererBase
	[BaseType (typeof(ChartRendererBase))]
	interface ChartLegendRenderer
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler legend:(ChartLegend * _Nullable)legend __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:legend:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, [NullAllowed] ChartLegend legend);

		// -(void)computeLegend:(ChartData * _Nonnull)data;
		[Export ("computeLegend:")]
		void ComputeLegend (ChartData data);

		// -(void)renderLegendWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLegendWithContext:")]
		unsafe void RenderLegendWithContext (CGContext context);
	}

	// @interface ChartLimitLine : ChartComponentBase
	[BaseType (typeof(ChartComponentBase))]
	interface ChartLimitLine
	{
		// @property (nonatomic) double limit;
		[Export ("limit")]
		double Limit { get; set; }

		// @property (nonatomic) UIColor * _Nonnull lineColor;
		[Export ("lineColor", ArgumentSemantic.Assign)]
		UIColor LineColor { get; set; }

		// @property (nonatomic) CGFloat lineDashPhase;
		[Export ("lineDashPhase")]
		nfloat LineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray * _Nullable lineDashLengths;
		[NullAllowed, Export ("lineDashLengths", ArgumentSemantic.Copy)]
        NSNumber[] LineDashLengths { get; set; }

		// @property (nonatomic) UIColor * _Nonnull valueTextColor;
		[Export ("valueTextColor", ArgumentSemantic.Assign)]
		UIColor ValueTextColor { get; set; }

		// @property (nonatomic) UIFont * _Nonnull valueFont;
		[Export ("valueFont", ArgumentSemantic.Assign)]
		UIFont ValueFont { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; set; }

		// @property (nonatomic) enum ChartLimitLabelPosition labelPosition;
		[Export ("labelPosition", ArgumentSemantic.Assign)]
		ChartLimitLabelPosition LabelPosition { get; set; }

		// -(instancetype _Nonnull)initWithLimit:(double)limit __attribute__((objc_designated_initializer));
		[Export ("initWithLimit:")]
		[DesignatedInitializer]
		IntPtr Constructor (double limit);

		// -(instancetype _Nonnull)initWithLimit:(double)limit label:(NSString * _Nonnull)label __attribute__((objc_designated_initializer));
		[Export ("initWithLimit:label:")]
		[DesignatedInitializer]
		IntPtr Constructor (double limit, string label);

		// @property (nonatomic) CGFloat lineWidth;
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }
	}

	// @interface ChartMarker : ChartComponentBase
	[BaseType (typeof(ChartComponentBase))]
	interface ChartMarker
	{
		// @property (nonatomic) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Assign)]
		UIImage Image { get; set; }

		// @property (nonatomic) CGPoint offset;
		[Export ("offset", ArgumentSemantic.Assign)]
		CGPoint Offset { get; set; }

		// @property (readonly, nonatomic) CGSize size;
		[Export ("size")]
		CGSize Size { get; }

		// -(CGPoint)offsetForDrawingAtPos:(CGPoint)point;
		[Export ("offsetForDrawingAtPos:")]
		CGPoint OffsetForDrawingAtPos (CGPoint point);

		// -(void)drawWithContext:(CGContextRef _Nonnull)context point:(CGPoint)point;
		[Export ("drawWithContext:point:")]
		unsafe void DrawWithContext (CGContext context, CGPoint point);

		// -(void)refreshContentWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export ("refreshContentWithEntry:highlight:")]
		void RefreshContentWithEntry (ChartDataEntry entry, ChartHighlight highlight);
	}

	// @interface ChartRange : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartRange
	{
		// @property (nonatomic) double from;
		[Export ("from")]
		double From { get; set; }

		// @property (nonatomic) double to;
		[Export ("to")]
		double To { get; set; }

		// -(instancetype _Nonnull)initFrom:(double)from to:(double)to __attribute__((objc_designated_initializer));
		[Export ("initFrom:to:")]
		[DesignatedInitializer]
		IntPtr Constructor (double from, double to);

		// -(BOOL)contains:(double)value;
		[Export ("contains:")]
		bool Contains (double value);

		// -(BOOL)isLarger:(double)value;
		[Export ("isLarger:")]
		bool IsLarger (double value);

		// -(BOOL)isSmaller:(double)value;
		[Export ("isSmaller:")]
		bool IsSmaller (double value);
	}

	// @interface ChartSelectionDetail : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartSelectionDetail
	{
		// -(instancetype _Nonnull)initWithValue:(double)value dataSetIndex:(NSInteger)dataSetIndex dataSet:(ChartDataSet * _Nonnull)dataSet __attribute__((objc_designated_initializer));
		[Export ("initWithValue:dataSetIndex:dataSet:")]
		[DesignatedInitializer]
		IntPtr Constructor (double value, nint dataSetIndex, ChartDataSet dataSet);

		// @property (readonly, nonatomic) double value;
		[Export ("value")]
		double Value { get; }

		// @property (readonly, nonatomic) NSInteger dataSetIndex;
		[Export ("dataSetIndex")]
		nint DataSetIndex { get; }

		// @property (readonly, nonatomic) ChartDataSet * _Nullable dataSet;
		[NullAllowed, Export ("dataSet")]
		ChartDataSet DataSet { get; }

		// -(BOOL)isEqual:(id _Nullable)object;
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);
	}

	// @interface ChartTransformer : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartTransformer
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler);

		// -(void)prepareMatrixValuePxWithChartXMin:(double)chartXMin deltaX:(CGFloat)deltaX deltaY:(CGFloat)deltaY chartYMin:(double)chartYMin;
		[Export ("prepareMatrixValuePxWithChartXMin:deltaX:deltaY:chartYMin:")]
		void PrepareMatrixValuePxWithChartXMin (double chartXMin, nfloat deltaX, nfloat deltaY, double chartYMin);

		// -(void)prepareMatrixOffset:(BOOL)inverted;
		[Export ("prepareMatrixOffset:")]
		void PrepareMatrixOffset (bool inverted);

		// -(CGPoint)getValueByTouchPoint:(CGPoint)point;
		[Export ("getValueByTouchPoint:")]
		CGPoint GetValueByTouchPoint (CGPoint point);

		// @property (readonly, nonatomic) CGAffineTransform valueToPixelMatrix;
		[Export ("valueToPixelMatrix")]
		CGAffineTransform ValueToPixelMatrix { get; }

		// @property (readonly, nonatomic) CGAffineTransform pixelToValueMatrix;
		[Export ("pixelToValueMatrix")]
		CGAffineTransform PixelToValueMatrix { get; }
	}

    #if false
	// @interface ChartTransformerHorizontalBarChart : ChartTransformer
	[BaseType (typeof(ChartTransformer))]
	interface ChartTransformerHorizontalBarChart
	{
		// -(void)prepareMatrixOffset:(BOOL)inverted;
		[Export ("prepareMatrixOffset:")]
		void PrepareMatrixOffset (bool inverted);

		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler);
	}
    #endif

	// @protocol ChartViewDelegate
	[Protocol, Model]
	interface ChartViewDelegate
	{
		// @optional -(void)chartValueSelected:(ChartViewBase * _Nonnull)chartView entry:(ChartDataEntry * _Nonnull)entry dataSetIndex:(NSInteger)dataSetIndex highlight:(ChartHighlight * _Nonnull)highlight;
		[Export ("chartValueSelected:entry:dataSetIndex:highlight:")]
		void ChartValueSelected (ChartViewBase chartView, ChartDataEntry entry, nint dataSetIndex, ChartHighlight highlight);

		// @optional -(void)chartValueNothingSelected:(ChartViewBase * _Nonnull)chartView;
		[Export ("chartValueNothingSelected:")]
		void ChartValueNothingSelected (ChartViewBase chartView);

		// @optional -(void)chartScaled:(ChartViewBase * _Nonnull)chartView scaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY;
		[Export ("chartScaled:scaleX:scaleY:")]
		void ChartScaled (ChartViewBase chartView, nfloat scaleX, nfloat scaleY);

		// @optional -(void)chartTranslated:(ChartViewBase * _Nonnull)chartView dX:(CGFloat)dX dY:(CGFloat)dY;
		[Export ("chartTranslated:dX:dY:")]
		void ChartTranslated (ChartViewBase chartView, nfloat dX, nfloat dY);
	}
        
	// @interface ChartViewPortHandler : NSObject
	[BaseType (typeof(NSObject))]
	interface ChartViewPortHandler
	{
		// -(instancetype _Nonnull)initWithWidth:(CGFloat)width height:(CGFloat)height __attribute__((objc_designated_initializer));
		[Export ("initWithWidth:height:")]
		[DesignatedInitializer]
		IntPtr Constructor (nfloat width, nfloat height);

		// -(void)setChartDimensWithWidth:(CGFloat)width height:(CGFloat)height;
		[Export ("setChartDimensWithWidth:height:")]
		void SetChartDimensWithWidth (nfloat width, nfloat height);

		// @property (readonly, nonatomic) BOOL hasChartDimens;
		[Export ("hasChartDimens")]
		bool HasChartDimens { get; }

		// -(void)restrainViewPortWithOffsetLeft:(CGFloat)offsetLeft offsetTop:(CGFloat)offsetTop offsetRight:(CGFloat)offsetRight offsetBottom:(CGFloat)offsetBottom;
		[Export ("restrainViewPortWithOffsetLeft:offsetTop:offsetRight:offsetBottom:")]
		void RestrainViewPortWithOffsetLeft (nfloat offsetLeft, nfloat offsetTop, nfloat offsetRight, nfloat offsetBottom);

		// @property (readonly, nonatomic) CGFloat offsetLeft;
		[Export ("offsetLeft")]
		nfloat OffsetLeft { get; }

		// @property (readonly, nonatomic) CGFloat offsetRight;
		[Export ("offsetRight")]
		nfloat OffsetRight { get; }

		// @property (readonly, nonatomic) CGFloat offsetTop;
		[Export ("offsetTop")]
		nfloat OffsetTop { get; }

		// @property (readonly, nonatomic) CGFloat offsetBottom;
		[Export ("offsetBottom")]
		nfloat OffsetBottom { get; }

		// @property (readonly, nonatomic) CGFloat contentTop;
		[Export ("contentTop")]
		nfloat ContentTop { get; }

		// @property (readonly, nonatomic) CGFloat contentLeft;
		[Export ("contentLeft")]
		nfloat ContentLeft { get; }

		// @property (readonly, nonatomic) CGFloat contentRight;
		[Export ("contentRight")]
		nfloat ContentRight { get; }

		// @property (readonly, nonatomic) CGFloat contentBottom;
		[Export ("contentBottom")]
		nfloat ContentBottom { get; }

		// @property (readonly, nonatomic) CGFloat contentWidth;
		[Export ("contentWidth")]
		nfloat ContentWidth { get; }

		// @property (readonly, nonatomic) CGFloat contentHeight;
		[Export ("contentHeight")]
		nfloat ContentHeight { get; }

		// @property (readonly, nonatomic) CGRect contentRect;
		[Export ("contentRect")]
		CGRect ContentRect { get; }

		// @property (readonly, nonatomic) CGPoint contentCenter;
		[Export ("contentCenter")]
		CGPoint ContentCenter { get; }

		// @property (readonly, nonatomic) CGFloat chartHeight;
		[Export ("chartHeight")]
		nfloat ChartHeight { get; }

		// @property (readonly, nonatomic) CGFloat chartWidth;
		[Export ("chartWidth")]
		nfloat ChartWidth { get; }

		// -(CGAffineTransform)zoomWithScaleX:(CGFloat)scaleX scaleY:(CGFloat)scaleY x:(CGFloat)x y:(CGFloat)y;
		[Export ("zoomWithScaleX:scaleY:x:y:")]
		CGAffineTransform ZoomWithScaleX (nfloat scaleX, nfloat scaleY, nfloat x, nfloat y);

		// -(CGAffineTransform)zoomInX:(CGFloat)x y:(CGFloat)y;
		[Export ("zoomInX:y:")]
		CGAffineTransform ZoomInX (nfloat x, nfloat y);

		// -(CGAffineTransform)zoomOutWithX:(CGFloat)x y:(CGFloat)y;
		[Export ("zoomOutWithX:y:")]
		CGAffineTransform ZoomOutWithX (nfloat x, nfloat y);

		// -(CGAffineTransform)fitScreen;
		[Export ("fitScreen")]
		CGAffineTransform FitScreen { get; }

		// -(void)centerViewPortWithPt:(CGPoint)pt chart:(ChartViewBase * _Nonnull)chart;
		[Export ("centerViewPortWithPt:chart:")]
		void CenterViewPortWithPt (CGPoint pt, ChartViewBase chart);

		// -(CGAffineTransform)refreshWithNewMatrix:(CGAffineTransform)newMatrix chart:(ChartViewBase * _Nonnull)chart invalidate:(BOOL)invalidate;
		[Export ("refreshWithNewMatrix:chart:invalidate:")]
		CGAffineTransform RefreshWithNewMatrix (CGAffineTransform newMatrix, ChartViewBase chart, bool invalidate);

		// -(void)setMinimumScaleX:(CGFloat)xScale;
		[Export ("setMinimumScaleX:")]
		void SetMinimumScaleX (nfloat xScale);

		// -(void)setMaximumScaleX:(CGFloat)xScale;
		[Export ("setMaximumScaleX:")]
		void SetMaximumScaleX (nfloat xScale);

		// -(void)setMinMaxScaleXWithMinScaleX:(CGFloat)minScaleX maxScaleX:(CGFloat)maxScaleX;
		[Export ("setMinMaxScaleXWithMinScaleX:maxScaleX:")]
		void SetMinMaxScaleXWithMinScaleX (nfloat minScaleX, nfloat maxScaleX);

		// -(void)setMinimumScaleY:(CGFloat)yScale;
		[Export ("setMinimumScaleY:")]
		void SetMinimumScaleY (nfloat yScale);

		// -(void)setMaximumScaleY:(CGFloat)yScale;
		[Export ("setMaximumScaleY:")]
		void SetMaximumScaleY (nfloat yScale);

		// @property (readonly, nonatomic) CGAffineTransform touchMatrix;
		[Export ("touchMatrix")]
		CGAffineTransform TouchMatrix { get; }

		// -(BOOL)isInBoundsX:(CGFloat)x;
		[Export ("isInBoundsX:")]
		bool IsInBoundsX (nfloat x);

		// -(BOOL)isInBoundsY:(CGFloat)y;
		[Export ("isInBoundsY:")]
		bool IsInBoundsY (nfloat y);

		// -(BOOL)isInBoundsWithX:(CGFloat)x y:(CGFloat)y;
		[Export ("isInBoundsWithX:y:")]
		bool IsInBoundsWithX (nfloat x, nfloat y);

		// -(BOOL)isInBoundsLeft:(CGFloat)x;
		[Export ("isInBoundsLeft:")]
		bool IsInBoundsLeft (nfloat x);

		// -(BOOL)isInBoundsRight:(CGFloat)x;
		[Export ("isInBoundsRight:")]
		bool IsInBoundsRight (nfloat x);

		// -(BOOL)isInBoundsTop:(CGFloat)y;
		[Export ("isInBoundsTop:")]
		bool IsInBoundsTop (nfloat y);

		// -(BOOL)isInBoundsBottom:(CGFloat)y;
		[Export ("isInBoundsBottom:")]
		bool IsInBoundsBottom (nfloat y);

		// @property (readonly, nonatomic) CGFloat scaleX;
		[Export ("scaleX")]
		nfloat ScaleX { get; }

		// @property (readonly, nonatomic) CGFloat scaleY;
		[Export ("scaleY")]
		nfloat ScaleY { get; }

		// @property (readonly, nonatomic) CGFloat transX;
		[Export ("transX")]
		nfloat TransX { get; }

		// @property (readonly, nonatomic) CGFloat transY;
		[Export ("transY")]
		nfloat TransY { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOut;
		[Export ("isFullyZoomedOut")]
		bool IsFullyZoomedOut { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOutY;
		[Export ("isFullyZoomedOutY")]
		bool IsFullyZoomedOutY { get; }

		// @property (readonly, nonatomic) BOOL isFullyZoomedOutX;
		[Export ("isFullyZoomedOutX")]
		bool IsFullyZoomedOutX { get; }

		// -(void)setDragOffsetX:(CGFloat)offset;
		[Export ("setDragOffsetX:")]
		void SetDragOffsetX (nfloat offset);

		// -(void)setDragOffsetY:(CGFloat)offset;
		[Export ("setDragOffsetY:")]
		void SetDragOffsetY (nfloat offset);

		// @property (readonly, nonatomic) BOOL hasNoDragOffset;
		[Export ("hasNoDragOffset")]
		bool HasNoDragOffset { get; }

		// @property (readonly, nonatomic) BOOL canZoomOutMoreX;
		[Export ("canZoomOutMoreX")]
		bool CanZoomOutMoreX { get; }

		// @property (readonly, nonatomic) BOOL canZoomInMoreX;
		[Export ("canZoomInMoreX")]
		bool CanZoomInMoreX { get; }

		// @property (readonly, nonatomic) BOOL canZoomOutMoreY;
		[Export ("canZoomOutMoreY")]
		bool CanZoomOutMoreY { get; }

		// @property (readonly, nonatomic) BOOL canZoomInMoreY;
		[Export ("canZoomInMoreY")]
		bool CanZoomInMoreY { get; }
	}

	// @interface ChartXAxis : ChartAxisBase
	[BaseType (typeof(ChartAxisBase))]
	interface ChartXAxis
	{
		// @property (nonatomic) CGFloat labelWidth;
		[Export ("labelWidth")]
		nfloat LabelWidth { get; set; }

		// @property (nonatomic) CGFloat labelHeight;
		[Export ("labelHeight")]
		nfloat LabelHeight { get; set; }

		// @property (nonatomic) CGFloat labelRotatedWidth;
		[Export ("labelRotatedWidth")]
		nfloat LabelRotatedWidth { get; set; }

		// @property (nonatomic) CGFloat labelRotatedHeight;
		[Export ("labelRotatedHeight")]
		nfloat LabelRotatedHeight { get; set; }

		// @property (nonatomic) CGFloat labelRotationAngle;
		[Export ("labelRotationAngle")]
		nfloat LabelRotationAngle { get; set; }

		// @property (nonatomic) NSInteger spaceBetweenLabels;
		[Export ("spaceBetweenLabels")]
		nint SpaceBetweenLabels { get; set; }

		// @property (nonatomic) NSInteger axisLabelModulus;
		[Export ("axisLabelModulus")]
		nint AxisLabelModulus { get; set; }

		// @property (nonatomic) NSInteger yAxisLabelModulus;
		[Export ("yAxisLabelModulus")]
		nint YAxisLabelModulus { get; set; }

		// @property (nonatomic) BOOL avoidFirstLastClippingEnabled;
		[Export ("avoidFirstLastClippingEnabled")]
		bool AvoidFirstLastClippingEnabled { get; set; }

		// @property (nonatomic) id<ChartXAxisValueFormatter> _Nullable valueFormatter;
		[NullAllowed, Export ("valueFormatter", ArgumentSemantic.Assign)]
		ChartXAxisValueFormatter ValueFormatter { get; set; }

		// @property (nonatomic) enum XAxisLabelPosition labelPosition;
		[Export ("labelPosition", ArgumentSemantic.Assign)]
		XAxisLabelPosition LabelPosition { get; set; }

		// @property (nonatomic) BOOL wordWrapEnabled;
		[Export ("wordWrapEnabled")]
		bool WordWrapEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isWordWrapEnabled;
		[Export ("isWordWrapEnabled")]
		bool IsWordWrapEnabled { get; }

		// @property (nonatomic) CGFloat wordWrapWidthPercent;
		[Export ("wordWrapWidthPercent")]
		nfloat WordWrapWidthPercent { get; set; }

		// -(NSString * _Nonnull)getLongestLabel;
		[Export ("getLongestLabel")]
		string LongestLabel { get; }

		// @property (readonly, nonatomic) BOOL isAvoidFirstLastClippingEnabled;
		[Export ("isAvoidFirstLastClippingEnabled")]
		bool IsAvoidFirstLastClippingEnabled { get; }

		// -(void)setLabelsToSkip:(NSInteger)count;
		[Export ("setLabelsToSkip:")]
		void SetLabelsToSkip (nint count);

		// -(void)resetLabelsToSkip;
		[Export ("resetLabelsToSkip")]
		void ResetLabelsToSkip ();

		// @property (readonly, nonatomic) BOOL isAxisModulusCustom;
		[Export ("isAxisModulusCustom")]
		bool IsAxisModulusCustom { get; }

		// @property (copy, nonatomic) NSArray * _Nonnull valuesObjc;
		[Export ("valuesObjc", ArgumentSemantic.Copy)]
		NSObject[] ValuesObjc { get; set; }
	}

	// @interface ChartXAxisRenderer : ChartAxisRendererBase
	[BaseType (typeof(ChartAxisRendererBase))]
	interface ChartXAxisRenderer
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:xAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, ChartTransformer transformer);

		// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLabelsWithContext:")]
		unsafe void RenderAxisLabelsWithContext (CGContext context);

		// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLineWithContext:")]
		unsafe void RenderAxisLineWithContext (CGContext context);

		// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderGridLinesWithContext:")]
		unsafe void RenderGridLinesWithContext (CGContext context);

		// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLimitLinesWithContext:")]
		unsafe void RenderLimitLinesWithContext (CGContext context);

		// -(void)renderLimitLineLineWithContext:(CGContextRef _Nonnull)context limitLine:(ChartLimitLine * _Nonnull)limitLine position:(CGPoint)position;
		[Export ("renderLimitLineLineWithContext:limitLine:position:")]
		unsafe void RenderLimitLineLineWithContext (CGContext context, ChartLimitLine limitLine, CGPoint position);

		// -(void)renderLimitLineLabelWithContext:(CGContextRef _Nonnull)context limitLine:(ChartLimitLine * _Nonnull)limitLine position:(CGPoint)position yOffset:(CGFloat)yOffset;
		[Export ("renderLimitLineLabelWithContext:limitLine:position:yOffset:")]
		unsafe void RenderLimitLineLabelWithContext (CGContext context, ChartLimitLine limitLine, CGPoint position, nfloat yOffset);
	}

    #if false
	// @interface ChartXAxisRendererBarChart : ChartXAxisRenderer
	[BaseType (typeof(ChartXAxisRenderer))]
	interface ChartXAxisRendererBarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis transformer:(ChartTransformer * _Null_unspecified)transformer chart:(BarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:xAxis:transformer:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, ChartTransformer transformer, BarChartView chart);

		// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderGridLinesWithContext:")]
		unsafe void RenderGridLinesWithContext (CGContextRef* context);
	}

	// @interface ChartXAxisRendererHorizontalBarChart : ChartXAxisRendererBarChart
	[BaseType (typeof(ChartXAxisRendererBarChart))]
	interface ChartXAxisRendererHorizontalBarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis transformer:(ChartTransformer * _Null_unspecified)transformer chart:(BarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:xAxis:transformer:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, ChartTransformer transformer, BarChartView chart);

		// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLabelsWithContext:")]
		unsafe void RenderAxisLabelsWithContext (CGContextRef* context);

		// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderGridLinesWithContext:")]
		unsafe void RenderGridLinesWithContext (CGContextRef* context);

		// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLineWithContext:")]
		unsafe void RenderAxisLineWithContext (CGContextRef* context);

		// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLimitLinesWithContext:")]
		unsafe void RenderLimitLinesWithContext (CGContextRef* context);
	}

	// @interface ChartXAxisRendererRadarChart : ChartXAxisRenderer
	[BaseType (typeof(ChartXAxisRenderer))]
	interface ChartXAxisRendererRadarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler xAxis:(ChartXAxis * _Nonnull)xAxis chart:(RadarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:xAxis:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartXAxis xAxis, RadarChartView chart);

		// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLabelsWithContext:")]
		unsafe void RenderAxisLabelsWithContext (CGContextRef* context);

		// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLimitLinesWithContext:")]
		unsafe void RenderLimitLinesWithContext (CGContextRef* context);
	}
    #endif

	// @interface ChartYAxis : ChartAxisBase
	[BaseType (typeof(ChartAxisBase))]
	interface ChartYAxis
	{
		// @property (copy, nonatomic) NSArray * _Nonnull entries;
		[Export ("entries", ArgumentSemantic.Copy)]
        NSNumber[] Entries { get; set; }

		// @property (readonly, nonatomic) NSInteger entryCount;
		[Export ("entryCount")]
		nint EntryCount { get; }

		// @property (nonatomic) BOOL drawTopYLabelEntryEnabled;
		[Export ("drawTopYLabelEntryEnabled")]
		bool DrawTopYLabelEntryEnabled { get; set; }

		// @property (nonatomic) BOOL showOnlyMinMaxEnabled;
		[Export ("showOnlyMinMaxEnabled")]
		bool ShowOnlyMinMaxEnabled { get; set; }

		// @property (nonatomic) BOOL inverted;
		[Export ("inverted")]
		bool Inverted { get; set; }

		// @property (nonatomic) BOOL startAtZeroEnabled;
		[Export ("startAtZeroEnabled")]
		bool StartAtZeroEnabled { get; set; }

		// @property (nonatomic) BOOL forceLabelsEnabled;
		[Export ("forceLabelsEnabled")]
		bool ForceLabelsEnabled { get; set; }

		// @property (nonatomic) NSNumberFormatter * _Nullable valueFormatter;
		[NullAllowed, Export ("valueFormatter", ArgumentSemantic.Assign)]
		NSNumberFormatter ValueFormatter { get; set; }

		// @property (nonatomic) double customAxisMin;
		[Export ("customAxisMin")]
		double CustomAxisMin { get; set; }

		// @property (nonatomic) double customAxisMax;
		[Export ("customAxisMax")]
		double CustomAxisMax { get; set; }

		// @property (nonatomic) CGFloat spaceTop;
		[Export ("spaceTop")]
		nfloat SpaceTop { get; set; }

		// @property (nonatomic) CGFloat spaceBottom;
		[Export ("spaceBottom")]
		nfloat SpaceBottom { get; set; }

		// @property (nonatomic) double axisMaximum;
		[Export ("axisMaximum")]
		double AxisMaximum { get; set; }

		// @property (nonatomic) double axisMinimum;
		[Export ("axisMinimum")]
		double AxisMinimum { get; set; }

		// @property (nonatomic) double axisRange;
		[Export ("axisRange")]
		double AxisRange { get; set; }

		// @property (nonatomic) enum YAxisLabelPosition labelPosition;
		[Export ("labelPosition", ArgumentSemantic.Assign)]
		YAxisLabelPosition LabelPosition { get; set; }

		// @property (nonatomic) CGFloat minWidth;
		[Export ("minWidth")]
		nfloat MinWidth { get; set; }

		// @property (nonatomic) CGFloat maxWidth;
		[Export ("maxWidth")]
		nfloat MaxWidth { get; set; }

		// -(instancetype _Nonnull)initWithPosition:(enum AxisDependency)position __attribute__((objc_designated_initializer));
		[Export ("initWithPosition:")]
		[DesignatedInitializer]
		IntPtr Constructor (AxisDependency position);

		// @property (readonly, nonatomic) enum AxisDependency axisDependency;
		[Export ("axisDependency")]
		AxisDependency AxisDependency { get; }

		// -(void)setLabelCount:(NSInteger)count force:(BOOL)force;
		[Export ("setLabelCount:force:")]
		void SetLabelCount (nint count, bool force);

		// @property (nonatomic) NSInteger labelCount;
		[Export ("labelCount")]
		nint LabelCount { get; set; }

		// -(void)resetCustomAxisMin;
		[Export ("resetCustomAxisMin")]
		void ResetCustomAxisMin ();

		// -(void)resetCustomAxisMax;
		[Export ("resetCustomAxisMax")]
		void ResetCustomAxisMax ();

		// -(CGSize)requiredSize;
		[Export ("requiredSize")]
		CGSize RequiredSize { get; }

		// -(CGFloat)getRequiredHeightSpace;
		[Export ("getRequiredHeightSpace")]
		nfloat RequiredHeightSpace { get; }

		// -(NSString * _Nonnull)getLongestLabel;
		[Export ("getLongestLabel")]
		string LongestLabel { get; }

		// -(NSString * _Nonnull)getFormattedLabel:(NSInteger)index;
		[Export ("getFormattedLabel:")]
		string GetFormattedLabel (nint index);

		// @property (readonly, nonatomic) BOOL needsOffset;
		[Export ("needsOffset")]
		bool NeedsOffset { get; }

		// @property (readonly, nonatomic) BOOL isInverted;
		[Export ("isInverted")]
		bool IsInverted { get; }

		// @property (readonly, nonatomic) BOOL isStartAtZeroEnabled;
		[Export ("isStartAtZeroEnabled")]
		bool IsStartAtZeroEnabled { get; }

		// @property (readonly, nonatomic) BOOL isForceLabelsEnabled;
		[Export ("isForceLabelsEnabled")]
		bool IsForceLabelsEnabled { get; }

		// @property (readonly, nonatomic) BOOL isShowOnlyMinMaxEnabled;
		[Export ("isShowOnlyMinMaxEnabled")]
		bool IsShowOnlyMinMaxEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawTopYLabelEntryEnabled;
		[Export ("isDrawTopYLabelEntryEnabled")]
		bool IsDrawTopYLabelEntryEnabled { get; }
	}

	// @interface ChartYAxisRenderer : ChartAxisRendererBase
	[BaseType (typeof(ChartAxisRendererBase))]
	interface ChartYAxisRenderer
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler yAxis:(ChartYAxis * _Nonnull)yAxis transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:yAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartYAxis yAxis, ChartTransformer transformer);

		// -(void)computeAxisWithYMin:(double)yMin yMax:(double)yMax;
		[Export ("computeAxisWithYMin:yMax:")]
		void ComputeAxisWithYMin (double yMin, double yMax);

		// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLabelsWithContext:")]
		unsafe void RenderAxisLabelsWithContext (CGContext context);

		// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLineWithContext:")]
		unsafe void RenderAxisLineWithContext (CGContext context);

		// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderGridLinesWithContext:")]
		unsafe void RenderGridLinesWithContext (CGContext context);

		// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLimitLinesWithContext:")]
		unsafe void RenderLimitLinesWithContext (CGContext context);
	}

    #if false
	// @interface ChartYAxisRendererHorizontalBarChart : ChartYAxisRenderer
	[BaseType (typeof(ChartYAxisRenderer))]
	interface ChartYAxisRendererHorizontalBarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler yAxis:(ChartYAxis * _Nonnull)yAxis transformer:(ChartTransformer * _Null_unspecified)transformer __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:yAxis:transformer:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartYAxis yAxis, ChartTransformer transformer);

		// -(void)computeAxisWithYMin:(double)yMin yMax:(double)yMax;
		[Export ("computeAxisWithYMin:yMax:")]
		void ComputeAxisWithYMin (double yMin, double yMax);

		// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLabelsWithContext:")]
		unsafe void RenderAxisLabelsWithContext (CGContextRef* context);

		// -(void)renderAxisLineWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLineWithContext:")]
		unsafe void RenderAxisLineWithContext (CGContextRef* context);

		// -(void)renderGridLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderGridLinesWithContext:")]
		unsafe void RenderGridLinesWithContext (CGContextRef* context);

		// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLimitLinesWithContext:")]
		unsafe void RenderLimitLinesWithContext (CGContextRef* context);
	}

	// @interface ChartYAxisRendererRadarChart : ChartYAxisRenderer
	[BaseType (typeof(ChartYAxisRenderer))]
	interface ChartYAxisRendererRadarChart
	{
		// -(instancetype _Nonnull)initWithViewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler yAxis:(ChartYAxis * _Nonnull)yAxis chart:(RadarChartView * _Nonnull)chart __attribute__((objc_designated_initializer));
		[Export ("initWithViewPortHandler:yAxis:chart:")]
		[DesignatedInitializer]
		IntPtr Constructor (ChartViewPortHandler viewPortHandler, ChartYAxis yAxis, RadarChartView chart);

		// -(void)computeAxisWithYMin:(double)yMin yMax:(double)yMax;
		[Export ("computeAxisWithYMin:yMax:")]
		void ComputeAxisWithYMin (double yMin, double yMax);

		// -(void)renderAxisLabelsWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderAxisLabelsWithContext:")]
		unsafe void RenderAxisLabelsWithContext (CGContextRef* context);

		// -(void)renderLimitLinesWithContext:(CGContextRef _Nonnull)context;
		[Export ("renderLimitLinesWithContext:")]
		unsafe void RenderLimitLinesWithContext (CGContextRef* context);
	}

	// @interface CombinedChartData : BarLineScatterCandleBubbleChartData
	[BaseType (typeof(BarLineScatterCandleBubbleChartData))]
	interface CombinedChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);

		// @property (nonatomic) LineChartData * _Null_unspecified lineData;
		[Export ("lineData", ArgumentSemantic.Assign)]
		LineChartData LineData { get; set; }

		// @property (nonatomic) BarChartData * _Null_unspecified barData;
		[Export ("barData", ArgumentSemantic.Assign)]
		BarChartData BarData { get; set; }

		// @property (nonatomic) ScatterChartData * _Null_unspecified scatterData;
		[Export ("scatterData", ArgumentSemantic.Assign)]
		ScatterChartData ScatterData { get; set; }

		// @property (nonatomic) CandleChartData * _Null_unspecified candleData;
		[Export ("candleData", ArgumentSemantic.Assign)]
		CandleChartData CandleData { get; set; }

		// @property (nonatomic) BubbleChartData * _Null_unspecified bubbleData;
		[Export ("bubbleData", ArgumentSemantic.Assign)]
		BubbleChartData BubbleData { get; set; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull allData;
		[Export ("allData", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AllData { get; }

		// -(void)notifyDataChanged;
		[Export ("notifyDataChanged")]
		void NotifyDataChanged ();
	}

	// @interface CombinedChartRenderer : ChartDataRendererBase
	[BaseType (typeof(ChartDataRendererBase))]
	interface CombinedChartRenderer
	{
		// @property (nonatomic) BOOL drawHighlightArrowEnabled;
		[Export ("drawHighlightArrowEnabled")]
		bool DrawHighlightArrowEnabled { get; set; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export ("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export ("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// -(instancetype _Nonnull)initWithChart:(CombinedChartView * _Nonnull)chart animator:(ChartAnimator * _Nonnull)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor (CombinedChartView chart, ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);

		// -(void)calcXBoundsWithChart:(BarLineChartViewBase * _Nonnull)chart xAxisModulus:(NSInteger)xAxisModulus;
		[Export ("calcXBoundsWithChart:xAxisModulus:")]
		void CalcXBoundsWithChart (BarLineChartViewBase chart, nint xAxisModulus);

		// -(ChartDataRendererBase * _Nullable)getSubRendererWithIndex:(NSInteger)index;
		[Export ("getSubRendererWithIndex:")]
		[return: NullAllowed]
		ChartDataRendererBase GetSubRendererWithIndex (nint index);

		// @property (copy, nonatomic) NSArray * _Nonnull subRenderers;
		[Export ("subRenderers", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SubRenderers { get; set; }

		// -(BarChartData * _Null_unspecified)barChartRendererData:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartRendererData:")]
		BarChartData BarChartRendererData (BarChartRenderer renderer);

		// -(ChartTransformer * _Null_unspecified)barChartRenderer:(BarChartRenderer * _Nonnull)renderer transformerForAxis:(enum AxisDependency)which;
		[Export ("barChartRenderer:transformerForAxis:")]
		ChartTransformer BarChartRenderer (BarChartRenderer renderer, AxisDependency which);

		// -(NSInteger)barChartRendererMaxVisibleValueCount:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartRendererMaxVisibleValueCount:")]
		nint BarChartRendererMaxVisibleValueCount (BarChartRenderer renderer);

		// -(NSNumberFormatter * _Null_unspecified)barChartDefaultRendererValueFormatter:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartDefaultRendererValueFormatter:")]
		NSNumberFormatter BarChartDefaultRendererValueFormatter (BarChartRenderer renderer);

		// -(double)barChartRendererChartYMax:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartRendererChartYMax:")]
		double BarChartRendererChartYMax (BarChartRenderer renderer);

		// -(double)barChartRendererChartYMin:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartRendererChartYMin:")]
		double BarChartRendererChartYMin (BarChartRenderer renderer);

		// -(double)barChartRendererChartXMax:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartRendererChartXMax:")]
		double BarChartRendererChartXMax (BarChartRenderer renderer);

		// -(double)barChartRendererChartXMin:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartRendererChartXMin:")]
		double BarChartRendererChartXMin (BarChartRenderer renderer);

		// -(BOOL)barChartIsDrawHighlightArrowEnabled:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartIsDrawHighlightArrowEnabled:")]
		bool BarChartIsDrawHighlightArrowEnabled (BarChartRenderer renderer);

		// -(BOOL)barChartIsDrawValueAboveBarEnabled:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartIsDrawValueAboveBarEnabled:")]
		bool BarChartIsDrawValueAboveBarEnabled (BarChartRenderer renderer);

		// -(BOOL)barChartIsDrawBarShadowEnabled:(BarChartRenderer * _Nonnull)renderer;
		[Export ("barChartIsDrawBarShadowEnabled:")]
		bool BarChartIsDrawBarShadowEnabled (BarChartRenderer renderer);

		// -(BOOL)barChartIsInverted:(BarChartRenderer * _Nonnull)renderer axis:(enum AxisDependency)axis;
		[Export ("barChartIsInverted:axis:")]
		bool BarChartIsInverted (BarChartRenderer renderer, AxisDependency axis);

		// -(ScatterChartData * _Null_unspecified)scatterChartRendererData:(ScatterChartRenderer * _Nonnull)renderer;
		[Export ("scatterChartRendererData:")]
		ScatterChartData ScatterChartRendererData (ScatterChartRenderer renderer);

		// -(ChartTransformer * _Null_unspecified)scatterChartRenderer:(ScatterChartRenderer * _Nonnull)renderer transformerForAxis:(enum AxisDependency)which;
		[Export ("scatterChartRenderer:transformerForAxis:")]
		ChartTransformer ScatterChartRenderer (ScatterChartRenderer renderer, AxisDependency which);

		// -(NSNumberFormatter * _Null_unspecified)scatterChartDefaultRendererValueFormatter:(ScatterChartRenderer * _Nonnull)renderer;
		[Export ("scatterChartDefaultRendererValueFormatter:")]
		NSNumberFormatter ScatterChartDefaultRendererValueFormatter (ScatterChartRenderer renderer);

		// -(double)scatterChartRendererChartYMax:(ScatterChartRenderer * _Nonnull)renderer;
		[Export ("scatterChartRendererChartYMax:")]
		double ScatterChartRendererChartYMax (ScatterChartRenderer renderer);

		// -(double)scatterChartRendererChartYMin:(ScatterChartRenderer * _Nonnull)renderer;
		[Export ("scatterChartRendererChartYMin:")]
		double ScatterChartRendererChartYMin (ScatterChartRenderer renderer);

		// -(double)scatterChartRendererChartXMax:(ScatterChartRenderer * _Nonnull)renderer;
		[Export ("scatterChartRendererChartXMax:")]
		double ScatterChartRendererChartXMax (ScatterChartRenderer renderer);

		// -(double)scatterChartRendererChartXMin:(ScatterChartRenderer * _Nonnull)renderer;
		[Export ("scatterChartRendererChartXMin:")]
		double ScatterChartRendererChartXMin (ScatterChartRenderer renderer);

		// -(NSInteger)scatterChartRendererMaxVisibleValueCount:(ScatterChartRenderer * _Nonnull)renderer;
		[Export ("scatterChartRendererMaxVisibleValueCount:")]
		nint ScatterChartRendererMaxVisibleValueCount (ScatterChartRenderer renderer);

		// -(CandleChartData * _Null_unspecified)candleStickChartRendererCandleData:(CandleStickChartRenderer * _Nonnull)renderer;
		[Export ("candleStickChartRendererCandleData:")]
		CandleChartData CandleStickChartRendererCandleData (CandleStickChartRenderer renderer);

		// -(ChartTransformer * _Null_unspecified)candleStickChartRenderer:(CandleStickChartRenderer * _Nonnull)renderer transformerForAxis:(enum AxisDependency)which;
		[Export ("candleStickChartRenderer:transformerForAxis:")]
		ChartTransformer CandleStickChartRenderer (CandleStickChartRenderer renderer, AxisDependency which);

		// -(NSNumberFormatter * _Null_unspecified)candleStickChartDefaultRendererValueFormatter:(CandleStickChartRenderer * _Nonnull)renderer;
		[Export ("candleStickChartDefaultRendererValueFormatter:")]
		NSNumberFormatter CandleStickChartDefaultRendererValueFormatter (CandleStickChartRenderer renderer);

		// -(double)candleStickChartRendererChartYMax:(CandleStickChartRenderer * _Nonnull)renderer;
		[Export ("candleStickChartRendererChartYMax:")]
		double CandleStickChartRendererChartYMax (CandleStickChartRenderer renderer);

		// -(double)candleStickChartRendererChartYMin:(CandleStickChartRenderer * _Nonnull)renderer;
		[Export ("candleStickChartRendererChartYMin:")]
		double CandleStickChartRendererChartYMin (CandleStickChartRenderer renderer);

		// -(double)candleStickChartRendererChartXMax:(CandleStickChartRenderer * _Nonnull)renderer;
		[Export ("candleStickChartRendererChartXMax:")]
		double CandleStickChartRendererChartXMax (CandleStickChartRenderer renderer);

		// -(double)candleStickChartRendererChartXMin:(CandleStickChartRenderer * _Nonnull)renderer;
		[Export ("candleStickChartRendererChartXMin:")]
		double CandleStickChartRendererChartXMin (CandleStickChartRenderer renderer);

		// -(NSInteger)candleStickChartRendererMaxVisibleValueCount:(CandleStickChartRenderer * _Nonnull)renderer;
		[Export ("candleStickChartRendererMaxVisibleValueCount:")]
		nint CandleStickChartRendererMaxVisibleValueCount (CandleStickChartRenderer renderer);

		// -(BubbleChartData * _Null_unspecified)bubbleChartRendererData:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartRendererData:")]
		BubbleChartData BubbleChartRendererData (BubbleChartRenderer renderer);

		// -(ChartTransformer * _Null_unspecified)bubbleChartRenderer:(BubbleChartRenderer * _Nonnull)renderer transformerForAxis:(enum AxisDependency)which;
		[Export ("bubbleChartRenderer:transformerForAxis:")]
		ChartTransformer BubbleChartRenderer (BubbleChartRenderer renderer, AxisDependency which);

		// -(NSNumberFormatter * _Null_unspecified)bubbleChartDefaultRendererValueFormatter:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartDefaultRendererValueFormatter:")]
		NSNumberFormatter BubbleChartDefaultRendererValueFormatter (BubbleChartRenderer renderer);

		// -(double)bubbleChartRendererChartYMax:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartRendererChartYMax:")]
		double BubbleChartRendererChartYMax (BubbleChartRenderer renderer);

		// -(double)bubbleChartRendererChartYMin:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartRendererChartYMin:")]
		double BubbleChartRendererChartYMin (BubbleChartRenderer renderer);

		// -(double)bubbleChartRendererChartXMax:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartRendererChartXMax:")]
		double BubbleChartRendererChartXMax (BubbleChartRenderer renderer);

		// -(double)bubbleChartRendererChartXMin:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartRendererChartXMin:")]
		double BubbleChartRendererChartXMin (BubbleChartRenderer renderer);

		// -(NSInteger)bubbleChartRendererMaxVisibleValueCount:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartRendererMaxVisibleValueCount:")]
		nint BubbleChartRendererMaxVisibleValueCount (BubbleChartRenderer renderer);

		// -(NSInteger)bubbleChartRendererXValCount:(BubbleChartRenderer * _Nonnull)renderer;
		[Export ("bubbleChartRendererXValCount:")]
		nint BubbleChartRendererXValCount (BubbleChartRenderer renderer);

		// @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Export ("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export ("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export ("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }
	}

	// @protocol LineChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol, Model]
	interface LineChartDataProvider : IBarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic) LineChartData * _Nullable lineData;
		[NullAllowed, Export ("lineData")]
		LineChartData LineData { get; }

		// @required -(ChartYAxis * _Nonnull)getAxis:(enum AxisDependency)axis;
		[Abstract]
		[Export ("getAxis:")]
		ChartYAxis GetAxis (AxisDependency axis);
	}

	// @protocol ScatterChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	[Protocol, Model]
	interface ScatterChartDataProvider : IBarLineScatterCandleBubbleChartDataProvider
	{
		// @required @property (readonly, nonatomic) ScatterChartData * _Nullable scatterData;
		[NullAllowed, Export ("scatterData")]
		ScatterChartData ScatterData { get; }
	}

	// @interface CombinedChartView : BarLineChartViewBase <BarChartDataProvider, ScatterChartDataProvider, CandleChartDataProvider, BubbleChartDataProvider, LineChartDataProvider>
	[BaseType (typeof(BarLineChartViewBase))]
	interface CombinedChartView : IBarChartDataProvider, IScatterChartDataProvider, ICandleChartDataProvider, IBubbleChartDataProvider, ILineChartDataProvider
	{
		// -(void)initialize;
		[Export ("initialize")]
		void Initialize ();

		// @property (nonatomic) ChartData * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Assign)]
		ChartData Data { get; set; }

		// @property (nonatomic) id<ChartFillFormatter> _Nonnull fillFormatter;
		[Export ("fillFormatter", ArgumentSemantic.Assign)]
		ChartFillFormatter FillFormatter { get; set; }

		// @property (readonly, nonatomic) LineChartData * _Nullable lineData;
		[NullAllowed, Export ("lineData")]
		LineChartData LineData { get; }

		// @property (readonly, nonatomic) BarChartData * _Nullable barData;
		[NullAllowed, Export ("barData")]
		BarChartData BarData { get; }

		// @property (readonly, nonatomic) ScatterChartData * _Nullable scatterData;
		[NullAllowed, Export ("scatterData")]
		ScatterChartData ScatterData { get; }

		// @property (readonly, nonatomic) CandleChartData * _Nullable candleData;
		[NullAllowed, Export ("candleData")]
		CandleChartData CandleData { get; }

		// @property (readonly, nonatomic) BubbleChartData * _Nullable bubbleData;
		[NullAllowed, Export ("bubbleData")]
		BubbleChartData BubbleData { get; }

		// @property (nonatomic) BOOL drawHighlightArrowEnabled;
		[Export ("drawHighlightArrowEnabled")]
		bool DrawHighlightArrowEnabled { get; set; }

		// @property (nonatomic) BOOL drawValueAboveBarEnabled;
		[Export ("drawValueAboveBarEnabled")]
		bool DrawValueAboveBarEnabled { get; set; }

		// @property (nonatomic) BOOL drawBarShadowEnabled;
		[Export ("drawBarShadowEnabled")]
		bool DrawBarShadowEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawHighlightArrowEnabled;
		[Export ("isDrawHighlightArrowEnabled")]
		bool IsDrawHighlightArrowEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawValueAboveBarEnabled;
		[Export ("isDrawValueAboveBarEnabled")]
		bool IsDrawValueAboveBarEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawBarShadowEnabled;
		[Export ("isDrawBarShadowEnabled")]
		bool IsDrawBarShadowEnabled { get; }

		// @property (copy, nonatomic) NSArray * _Nonnull drawOrder;
		[Export ("drawOrder", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] DrawOrder { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface HorizontalBarChartRenderer : BarChartRenderer
	[BaseType (typeof(BarChartRenderer))]
	interface HorizontalBarChartRenderer
	{
		// -(instancetype _Nonnull)initWithDataProvider:(id<BarChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] BarChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);
	}

	// @interface HorizontalBarChartView : BarChartView
	[BaseType (typeof(BarChartView))]
	interface HorizontalBarChartView
	{
		// -(CGPoint)getPosition:(ChartDataEntry * _Nonnull)e axis:(enum AxisDependency)axis;
		[Export ("getPosition:axis:")]
		CGPoint GetPosition (ChartDataEntry e, AxisDependency axis);

		// -(ChartHighlight * _Nullable)getHighlightByTouchPoint:(CGPoint)pt;
		[Export ("getHighlightByTouchPoint:")]
		[return: NullAllowed]
		ChartHighlight GetHighlightByTouchPoint (CGPoint pt);

		// @property (readonly, nonatomic) NSInteger lowestVisibleXIndex;
		[Export ("lowestVisibleXIndex")]
		nint LowestVisibleXIndex { get; }

		// @property (readonly, nonatomic) NSInteger highestVisibleXIndex;
		[Export ("highestVisibleXIndex")]
		nint HighestVisibleXIndex { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface LineChartData : ChartData
	[BaseType (typeof(ChartData))]
	interface LineChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);
	}

	// @interface LineRadarChartDataSet : LineScatterCandleChartDataSet
	[BaseType (typeof(LineScatterCandleChartDataSet))]
	interface LineRadarChartDataSet
	{
		// @property (nonatomic) UIColor * _Nonnull fillColor;
		[Export ("fillColor", ArgumentSemantic.Assign)]
		UIColor FillColor { get; set; }

		// @property (nonatomic) CGFloat fillAlpha;
		[Export ("fillAlpha")]
		nfloat FillAlpha { get; set; }

		// @property (nonatomic) BOOL drawFilledEnabled;
		[Export ("drawFilledEnabled")]
		bool DrawFilledEnabled { get; set; }

		// @property (nonatomic) CGFloat lineWidth;
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawFilledEnabled;
		[Export ("isDrawFilledEnabled")]
		bool IsDrawFilledEnabled { get; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);
	}

	// @interface LineChartDataSet : LineRadarChartDataSet
	[BaseType (typeof(LineRadarChartDataSet))]
	interface LineChartDataSet
	{
		// @property (copy, nonatomic) NSArray * _Nonnull circleColors;
		[Export ("circleColors", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] CircleColors { get; set; }

		// @property (nonatomic) UIColor * _Nonnull circleHoleColor;
		[Export ("circleHoleColor", ArgumentSemantic.Assign)]
		UIColor CircleHoleColor { get; set; }

		// @property (nonatomic) CGFloat circleRadius;
		[Export ("circleRadius")]
		nfloat CircleRadius { get; set; }

		// @property (nonatomic) CGFloat lineDashPhase;
		[Export ("lineDashPhase")]
		nfloat LineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray * _Null_unspecified lineDashLengths;
		[Export ("lineDashLengths", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] LineDashLengths { get; set; }

		// @property (nonatomic) BOOL drawCirclesEnabled;
		[Export ("drawCirclesEnabled")]
		bool DrawCirclesEnabled { get; set; }

		// @property (nonatomic) BOOL drawCubicEnabled;
		[Export ("drawCubicEnabled")]
		bool DrawCubicEnabled { get; set; }

		// @property (nonatomic) BOOL drawCircleHoleEnabled;
		[Export ("drawCircleHoleEnabled")]
		bool DrawCircleHoleEnabled { get; set; }

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);

		// @property (nonatomic) CGFloat cubicIntensity;
		[Export ("cubicIntensity")]
		nfloat CubicIntensity { get; set; }

		// -(UIColor * _Nullable)getCircleColor:(NSInteger)index;
		[Export ("getCircleColor:")]
		[return: NullAllowed]
		UIColor GetCircleColor (nint index);

		// -(void)setCircleColor:(UIColor * _Nonnull)color;
		[Export ("setCircleColor:")]
		void SetCircleColor (UIColor color);

		// -(void)resetCircleColors:(NSInteger)index;
		[Export ("resetCircleColors:")]
		void ResetCircleColors (nint index);

		// @property (readonly, nonatomic) BOOL isDrawCirclesEnabled;
		[Export ("isDrawCirclesEnabled")]
		bool IsDrawCirclesEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawCubicEnabled;
		[Export ("isDrawCubicEnabled")]
		bool IsDrawCubicEnabled { get; }

		// @property (readonly, nonatomic) BOOL isDrawCircleHoleEnabled;
		[Export ("isDrawCircleHoleEnabled")]
		bool IsDrawCircleHoleEnabled { get; }

		// @property (nonatomic) id<ChartFillFormatter> _Nullable fillFormatter;
		[NullAllowed, Export ("fillFormatter", ArgumentSemantic.Assign)]
		ChartFillFormatter FillFormatter { get; set; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);
	}

	// @interface LineChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType (typeof(LineScatterCandleRadarChartRenderer))]
	interface LineChartRenderer
	{
		// @property (nonatomic, weak) id<LineChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export ("dataProvider", ArgumentSemantic.Weak)]
		LineChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<LineChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] LineChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);
	}

	// @interface LineChartView : BarLineChartViewBase <LineChartDataProvider>
	[BaseType (typeof(BarLineChartViewBase))]
	interface LineChartView : ILineChartDataProvider
	{
		// @property (readonly, nonatomic) LineChartData * _Nullable lineData;
		[NullAllowed, Export ("lineData")]
		LineChartData LineData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface PieChartData : ChartData
	[BaseType (typeof(ChartData))]
	interface PieChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);

		// -(ChartDataSet * _Nullable)getDataSetByIndex:(NSInteger)index;
		[Export ("getDataSetByIndex:")]
		[return: NullAllowed]
		ChartDataSet GetDataSetByIndex (nint index);

		// -(ChartDataSet * _Nullable)getDataSetByLabel:(NSString * _Nonnull)label ignorecase:(BOOL)ignorecase;
		[Export ("getDataSetByLabel:ignorecase:")]
		[return: NullAllowed]
		ChartDataSet GetDataSetByLabel (string label, bool ignorecase);
	}

	// @interface PieChartDataSet : ChartDataSet
	[BaseType (typeof(ChartDataSet))]
	interface PieChartDataSet
	{
		// @property (nonatomic) CGFloat selectionShift;
		[Export ("selectionShift")]
		nfloat SelectionShift { get; set; }

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);

		// @property (nonatomic) CGFloat sliceSpace;
		[Export ("sliceSpace")]
		nfloat SliceSpace { get; set; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);
	}

	// @interface PieChartRenderer : ChartDataRendererBase
	[BaseType (typeof(ChartDataRendererBase))]
	interface PieChartRenderer
	{
		// @property (nonatomic) BOOL drawHoleEnabled;
		[Export ("drawHoleEnabled")]
		bool DrawHoleEnabled { get; set; }

		// @property (nonatomic) BOOL holeTransparent;
		[Export ("holeTransparent")]
		bool HoleTransparent { get; set; }

		// @property (nonatomic) UIColor * _Nullable holeColor;
		[NullAllowed, Export ("holeColor", ArgumentSemantic.Assign)]
		UIColor HoleColor { get; set; }

		// @property (nonatomic) CGFloat holeRadiusPercent;
		[Export ("holeRadiusPercent")]
		nfloat HoleRadiusPercent { get; set; }

		// @property (nonatomic) CGFloat holeAlpha;
		[Export ("holeAlpha")]
		nfloat HoleAlpha { get; set; }

		// @property (nonatomic) CGFloat transparentCircleRadiusPercent;
		[Export ("transparentCircleRadiusPercent")]
		nfloat TransparentCircleRadiusPercent { get; set; }

		// @property (nonatomic) BOOL drawXLabelsEnabled;
		[Export ("drawXLabelsEnabled")]
		bool DrawXLabelsEnabled { get; set; }

		// @property (nonatomic) BOOL usePercentValuesEnabled;
		[Export ("usePercentValuesEnabled")]
		bool UsePercentValuesEnabled { get; set; }

		// @property (nonatomic) NSAttributedString * _Nullable centerAttributedText;
		[NullAllowed, Export ("centerAttributedText", ArgumentSemantic.Assign)]
		NSAttributedString CenterAttributedText { get; set; }

		// @property (nonatomic) BOOL drawCenterTextEnabled;
		[Export ("drawCenterTextEnabled")]
		bool DrawCenterTextEnabled { get; set; }

		// @property (nonatomic) CGFloat centerTextRadiusPercent;
		[Export ("centerTextRadiusPercent")]
		nfloat CenterTextRadiusPercent { get; set; }

		// -(instancetype _Nonnull)initWithChart:(PieChartView * _Nonnull)chart animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor (PieChartView chart, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);
	}
    #endif

	// @interface PieRadarChartViewBase : ChartViewBase
	[BaseType (typeof(ChartViewBase))]
	interface PieRadarChartViewBase
	{
		// @property (nonatomic) BOOL rotationEnabled;
		[Export ("rotationEnabled")]
		bool RotationEnabled { get; set; }

		// @property (nonatomic) CGFloat minOffset;
		[Export ("minOffset")]
		nfloat MinOffset { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export ("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);

		// -(void)notifyDataSetChanged;
		[Export ("notifyDataSetChanged")]
		void NotifyDataSetChanged ();

		// -(CGFloat)angleForPointWithX:(CGFloat)x y:(CGFloat)y;
		[Export ("angleForPointWithX:y:")]
		nfloat AngleForPointWithX (nfloat x, nfloat y);

		// -(CGFloat)distanceToCenterWithX:(CGFloat)x y:(CGFloat)y;
		[Export ("distanceToCenterWithX:y:")]
		nfloat DistanceToCenterWithX (nfloat x, nfloat y);

		// -(NSInteger)indexForAngle:(CGFloat)angle;
		[Export ("indexForAngle:")]
		nint IndexForAngle (nfloat angle);

		// @property (nonatomic) CGFloat rotationAngle;
		[Export ("rotationAngle")]
		nfloat RotationAngle { get; set; }

		// @property (readonly, nonatomic) CGFloat rawRotationAngle;
		[Export ("rawRotationAngle")]
		nfloat RawRotationAngle { get; }

		// @property (readonly, nonatomic) CGFloat diameter;
		[Export ("diameter")]
		nfloat Diameter { get; }

		// @property (readonly, nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; }

		// @property (readonly, nonatomic) double chartXMax;
		[Export ("chartXMax")]
		double ChartXMax { get; }

		// @property (readonly, nonatomic) double chartXMin;
		[Export ("chartXMin")]
		double ChartXMin { get; }

		// -(NSArray * _Nonnull)getSelectionDetailsAtIndex:(NSInteger)xIndex;
		[Export ("getSelectionDetailsAtIndex:")]
        ChartSelectionDetail[] GetSelectionDetailsAtIndex (nint xIndex);

		// @property (readonly, nonatomic) BOOL isRotationEnabled;
		[Export ("isRotationEnabled")]
		bool IsRotationEnabled { get; }

		// @property (nonatomic) BOOL rotationWithTwoFingers;
		[Export ("rotationWithTwoFingers")]
		bool RotationWithTwoFingers { get; set; }

		// @property (readonly, nonatomic) BOOL isRotationWithTwoFingers;
		[Export ("isRotationWithTwoFingers")]
		bool IsRotationWithTwoFingers { get; }

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle easing:(CGFloat (^ _Nullable)(NSTimeInterval, NSTimeInterval))easing;
		[Export ("spinWithDuration:fromAngle:toAngle:easing:")]
		void SpinWithDuration (double duration, nfloat fromAngle, nfloat toAngle, [NullAllowed] Func<double, double, nfloat> easing);

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle easingOption:(enum ChartEasingOption)easingOption;
		[Export ("spinWithDuration:fromAngle:toAngle:easingOption:")]
		void SpinWithDuration (double duration, nfloat fromAngle, nfloat toAngle, ChartEasingOption easingOption);

		// -(void)spinWithDuration:(NSTimeInterval)duration fromAngle:(CGFloat)fromAngle toAngle:(CGFloat)toAngle;
		[Export ("spinWithDuration:fromAngle:toAngle:")]
		void SpinWithDuration (double duration, nfloat fromAngle, nfloat toAngle);

		// -(void)stopSpinAnimation;
		[Export ("stopSpinAnimation")]
		void StopSpinAnimation ();

		// -(void)touchesBegan:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet touches, [NullAllowed] UIEvent @event);

		// -(void)touchesMoved:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesMoved:withEvent:")]
		void TouchesMoved (NSSet touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled ([NullAllowed] NSSet touches, [NullAllowed] UIEvent @event);

		// -(void)stopDeceleration;
		[Export ("stopDeceleration")]
		void StopDeceleration ();
	}

	// @interface PieChartView : PieRadarChartViewBase
	[BaseType (typeof(PieRadarChartViewBase))]
	interface PieChartView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export ("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)e highlight:(ChartHighlight * _Nonnull)highlight;
		[Export ("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry (ChartDataEntry e, ChartHighlight highlight);

		// -(BOOL)needsHighlightWithXIndex:(NSInteger)xIndex dataSetIndex:(NSInteger)dataSetIndex;
		[Export ("needsHighlightWithXIndex:dataSetIndex:")]
		bool NeedsHighlightWithXIndex (nint xIndex, nint dataSetIndex);

		// -(NSInteger)indexForAngle:(CGFloat)angle;
		[Export ("indexForAngle:")]
		nint IndexForAngle (nfloat angle);

		// -(NSInteger)dataSetIndexForIndex:(NSInteger)xIndex;
		[Export ("dataSetIndexForIndex:")]
		nint DataSetIndexForIndex (nint xIndex);

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull drawAngles;
		[Export ("drawAngles", ArgumentSemantic.Copy)]
        NSNumber[] DrawAngles { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull absoluteAngles;
		[Export ("absoluteAngles", ArgumentSemantic.Copy)]
        NSNumber[] AbsoluteAngles { get; }

		// @property (nonatomic) UIColor * _Nullable holeColor;
		[NullAllowed, Export ("holeColor", ArgumentSemantic.Assign)]
		UIColor HoleColor { get; set; }

		// @property (nonatomic) BOOL holeTransparent;
		[Export ("holeTransparent")]
		bool HoleTransparent { get; set; }

		// @property (readonly, nonatomic) BOOL isHoleTransparent;
		[Export ("isHoleTransparent")]
		bool IsHoleTransparent { get; }

		// @property (nonatomic) CGFloat holeAlpha;
		[Export ("holeAlpha")]
		nfloat HoleAlpha { get; set; }

		// @property (nonatomic) BOOL drawHoleEnabled;
		[Export ("drawHoleEnabled")]
		bool DrawHoleEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawHoleEnabled;
		[Export ("isDrawHoleEnabled")]
		bool IsDrawHoleEnabled { get; }

		// @property (copy, nonatomic) NSString * _Nullable centerText;
		[NullAllowed, Export ("centerText")]
		string CenterText { get; set; }

		// @property (nonatomic) NSAttributedString * _Nullable centerAttributedText;
		[NullAllowed, Export ("centerAttributedText", ArgumentSemantic.Assign)]
		NSAttributedString CenterAttributedText { get; set; }

		// @property (nonatomic) BOOL drawCenterTextEnabled;
		[Export ("drawCenterTextEnabled")]
		bool DrawCenterTextEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawCenterTextEnabled;
		[Export ("isDrawCenterTextEnabled")]
		bool IsDrawCenterTextEnabled { get; }

		// @property (readonly, nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; }

		// @property (readonly, nonatomic) CGRect circleBox;
		[Export ("circleBox")]
		CGRect CircleBox { get; }

		// @property (readonly, nonatomic) CGPoint centerCircleBox;
		[Export ("centerCircleBox")]
		CGPoint CenterCircleBox { get; }

		// @property (nonatomic) CGFloat holeRadiusPercent;
		[Export ("holeRadiusPercent")]
		nfloat HoleRadiusPercent { get; set; }

		// @property (nonatomic) CGFloat transparentCircleRadiusPercent;
		[Export ("transparentCircleRadiusPercent")]
		nfloat TransparentCircleRadiusPercent { get; set; }

		// @property (nonatomic) BOOL drawSliceTextEnabled;
		[Export ("drawSliceTextEnabled")]
		bool DrawSliceTextEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isDrawSliceTextEnabled;
		[Export ("isDrawSliceTextEnabled")]
		bool IsDrawSliceTextEnabled { get; }

		// @property (nonatomic) BOOL usePercentValuesEnabled;
		[Export ("usePercentValuesEnabled")]
		bool UsePercentValuesEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isUsePercentValuesEnabled;
		[Export ("isUsePercentValuesEnabled")]
		bool IsUsePercentValuesEnabled { get; }

		// @property (nonatomic) CGFloat centerTextRadiusPercent;
		[Export ("centerTextRadiusPercent")]
		nfloat CenterTextRadiusPercent { get; set; }
	}

    #if false
	// @interface RadarChartData : ChartData
	[BaseType (typeof(ChartData))]
	interface RadarChartData
	{
		// @property (nonatomic) UIColor * _Nonnull highlightColor;
		[Export ("highlightColor", ArgumentSemantic.Assign)]
		UIColor HighlightColor { get; set; }

		// @property (nonatomic) CGFloat highlightLineWidth;
		[Export ("highlightLineWidth")]
		nfloat HighlightLineWidth { get; set; }

		// @property (nonatomic) CGFloat highlightLineDashPhase;
		[Export ("highlightLineDashPhase")]
		nfloat HighlightLineDashPhase { get; set; }

		// @property (copy, nonatomic) NSArray * _Nullable highlightLineDashLengths;
		[NullAllowed, Export ("highlightLineDashLengths", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] HighlightLineDashLengths { get; set; }

		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);
	}

	// @interface RadarChartDataSet : LineRadarChartDataSet
	[BaseType (typeof(LineRadarChartDataSet))]
	interface RadarChartDataSet
	{
		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);
	}

	// @interface RadarChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType (typeof(LineScatterCandleRadarChartRenderer))]
	interface RadarChartRenderer
	{
		// -(instancetype _Nonnull)initWithChart:(RadarChartView * _Nonnull)chart animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithChart:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor (RadarChartView chart, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);
	}

	// @interface RadarChartView : PieRadarChartViewBase
	[BaseType (typeof(PieRadarChartViewBase))]
	interface RadarChartView
	{
		// @property (nonatomic) CGFloat webLineWidth;
		[Export ("webLineWidth")]
		nfloat WebLineWidth { get; set; }

		// @property (nonatomic) CGFloat innerWebLineWidth;
		[Export ("innerWebLineWidth")]
		nfloat InnerWebLineWidth { get; set; }

		// @property (nonatomic) UIColor * _Nonnull webColor;
		[Export ("webColor", ArgumentSemantic.Assign)]
		UIColor WebColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull innerWebColor;
		[Export ("innerWebColor", ArgumentSemantic.Assign)]
		UIColor InnerWebColor { get; set; }

		// @property (nonatomic) CGFloat webAlpha;
		[Export ("webAlpha")]
		nfloat WebAlpha { get; set; }

		// @property (nonatomic) BOOL drawWeb;
		[Export ("drawWeb")]
		bool DrawWeb { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(CGPoint)getMarkerPositionWithEntry:(ChartDataEntry * _Nonnull)entry highlight:(ChartHighlight * _Nonnull)highlight;
		[Export ("getMarkerPositionWithEntry:highlight:")]
		CGPoint GetMarkerPositionWithEntry (ChartDataEntry entry, ChartHighlight highlight);

		// -(void)notifyDataSetChanged;
		[Export ("notifyDataSetChanged")]
		void NotifyDataSetChanged ();

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);

		// @property (readonly, nonatomic) CGFloat factor;
		[Export ("factor")]
		nfloat Factor { get; }

		// @property (readonly, nonatomic) CGFloat sliceAngle;
		[Export ("sliceAngle")]
		nfloat SliceAngle { get; }

		// -(NSInteger)indexForAngle:(CGFloat)angle;
		[Export ("indexForAngle:")]
		nint IndexForAngle (nfloat angle);

		// @property (readonly, nonatomic) ChartYAxis * _Nonnull yAxis;
		[Export ("yAxis")]
		ChartYAxis YAxis { get; }

		// @property (readonly, nonatomic) ChartXAxis * _Nonnull xAxis;
		[Export ("xAxis")]
		ChartXAxis XAxis { get; }

		// @property (nonatomic) NSInteger skipWebLineCount;
		[Export ("skipWebLineCount")]
		nint SkipWebLineCount { get; set; }

		// @property (readonly, nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; }

		// @property (readonly, nonatomic) double chartYMax;
		[Export ("chartYMax")]
		double ChartYMax { get; }

		// @property (readonly, nonatomic) double chartYMin;
		[Export ("chartYMin")]
		double ChartYMin { get; }

		// @property (readonly, nonatomic) double yRange;
		[Export ("yRange")]
		double YRange { get; }
	}

	// @interface ScatterChartData : BarLineScatterCandleBubbleChartData
	[BaseType (typeof(BarLineScatterCandleBubbleChartData))]
	interface ScatterChartData
	{
		// -(instancetype _Nonnull)initWithXVals:(NSArray * _Nullable)xVals dataSets:(NSArray * _Nullable)dataSets __attribute__((objc_designated_initializer));
		[Export ("initWithXVals:dataSets:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] xVals, [NullAllowed] NSObject[] dataSets);

		// -(CGFloat)getGreatestShapeSize;
		[Export ("getGreatestShapeSize")]
		[Verify (MethodToProperty)]
		nfloat GreatestShapeSize { get; }
	}

	// @interface ScatterChartDataSet : LineScatterCandleChartDataSet
	[BaseType (typeof(LineScatterCandleChartDataSet))]
	interface ScatterChartDataSet
	{
		// @property (nonatomic) CGFloat scatterShapeSize;
		[Export ("scatterShapeSize")]
		nfloat ScatterShapeSize { get; set; }

		// @property (nonatomic) enum ScatterShape scatterShape;
		[Export ("scatterShape", ArgumentSemantic.Assign)]
		ScatterShape ScatterShape { get; set; }

		// @property (nonatomic) CGPathRef _Nullable customScatterShape;
		[NullAllowed, Export ("customScatterShape", ArgumentSemantic.Assign)]
		unsafe CGPathRef* CustomScatterShape { get; set; }

		// -(id _Nonnull)copyWithZone:(NSZone * _Null_unspecified)zone;
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (NSZone* zone);

		// -(instancetype _Nonnull)initWithYVals:(NSArray * _Nullable)yVals label:(NSString * _Nullable)label __attribute__((objc_designated_initializer));
		[Export ("initWithYVals:label:")]
		[DesignatedInitializer]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject[] yVals, [NullAllowed] string label);
	}

	// @interface ScatterChartRenderer : LineScatterCandleRadarChartRenderer
	[BaseType (typeof(LineScatterCandleRadarChartRenderer))]
	interface ScatterChartRenderer
	{
		// @property (nonatomic, weak) id<ScatterChartDataProvider> _Nullable dataProvider;
		[NullAllowed, Export ("dataProvider", ArgumentSemantic.Weak)]
		ScatterChartDataProvider DataProvider { get; set; }

		// -(instancetype _Nonnull)initWithDataProvider:(id<ScatterChartDataProvider> _Nullable)dataProvider animator:(ChartAnimator * _Nullable)animator viewPortHandler:(ChartViewPortHandler * _Nonnull)viewPortHandler __attribute__((objc_designated_initializer));
		[Export ("initWithDataProvider:animator:viewPortHandler:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] ScatterChartDataProvider dataProvider, [NullAllowed] ChartAnimator animator, ChartViewPortHandler viewPortHandler);

		// -(void)drawDataWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawDataWithContext:")]
		unsafe void DrawDataWithContext (CGContextRef* context);

		// -(void)drawValuesWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawValuesWithContext:")]
		unsafe void DrawValuesWithContext (CGContextRef* context);

		// -(void)drawExtrasWithContext:(CGContextRef _Nonnull)context;
		[Export ("drawExtrasWithContext:")]
		unsafe void DrawExtrasWithContext (CGContextRef* context);

		// -(void)drawHighlightedWithContext:(CGContextRef _Nonnull)context indices:(NSArray * _Nonnull)indices;
		[Export ("drawHighlightedWithContext:indices:")]
		[Verify (StronglyTypedNSArray)]
		unsafe void DrawHighlightedWithContext (CGContextRef* context, NSObject[] indices);
	}

	// @interface ScatterChartView : BarLineChartViewBase <ScatterChartDataProvider>
	[BaseType (typeof(BarLineChartViewBase))]
	interface ScatterChartView : IScatterChartDataProvider
	{
		// -(void)initialize;
		[Export ("initialize")]
		void Initialize ();

		// -(void)calcMinMax;
		[Export ("calcMinMax")]
		void CalcMinMax ();

		// @property (readonly, nonatomic) ScatterChartData * _Nullable scatterData;
		[NullAllowed, Export ("scatterData")]
		ScatterChartData ScatterData { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double ChartsVersionNumber;
		[Field ("ChartsVersionNumber", "__Internal")]
		double ChartsVersionNumber { get; }

		// extern const unsigned char [] ChartsVersionString;
		[Field ("ChartsVersionString", "__Internal")]
		byte[] ChartsVersionString { get; }
	}

    #endif
}
