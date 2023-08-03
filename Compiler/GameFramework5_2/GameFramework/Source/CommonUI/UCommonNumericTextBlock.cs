#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Numeric text block that provides interpolation, and some type support (numbers, percents, seconds, distance).</summary>
[CppInclude("CommonNumericTextBlock.h")]
public partial class UCommonNumericTextBlock : UCommonTextBlock {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the value this widget will ultimately show if it is interpolating, or the current value if it is not.</summary>
	public  float GetTargetValue() { return default; }
	///<summary>Sets the current numeric value. NOTE: Cancels any ongoing interpolation!</summary>
	public  void SetCurrentValue(float NewValue) {}
	///<summary>Starts an ongoing process of interpolating the current numeric value to the specified target value.</summary>
	public  void InterpolateToValue(float TargetValue,float MaximumInterpolationDuration/*=3.0f*/,float MinimumChangeRate/*=1.0f*/,float OutroOffset/*=0.0f*/) {}
	///<summary>IsInterpolatingNumericValue</summary>
	public  bool IsInterpolatingNumericValue() { return default; }
	///<summary>FOnInterpolationStarted</summary>
	public  void FOnInterpolationStarted(UCommonNumericTextBlock NumericTextBlock) {}
	///<summary>Event triggered when interpolation has started.</summary>
	public FOnInterpolationStarted OnInterpolationStartedEvent;
	///<summary>FOnInterpolationUpdated</summary>
	public  void FOnInterpolationUpdated(UCommonNumericTextBlock NumericTextBlock,float LastValue,float NewValue) {}
	///<summary>Event triggered when interpolation has updated.</summary>
	public FOnInterpolationUpdated OnInterpolationUpdatedEvent;
	///<summary>FOnOutro</summary>
	public  void FOnOutro(UCommonNumericTextBlock NumericTextBlock) {}
	///<summary>Event triggered at a specified time before the interpolation completes, for &quot;outro&quot; purposes.</summary>
	public FOnOutro OnOutroEvent;
	///<summary>FOnInterpolationEnded</summary>
	public  void FOnInterpolationEnded(UCommonNumericTextBlock NumericTextBlock,bool HadCompleted) {}
	///<summary>Event triggered when interpolation has ended.</summary>
	public FOnInterpolationEnded OnInterpolationEndedEvent;
	///<summary>The current numeric value being formatted for display, potentially being interpolated from. NOTE: The displayed text is very likely not identical to this value, due to formatting.</summary>
	public float CurrentNumericValue;
	///<summary>SetNumericType</summary>
	public  void SetNumericType(ECommonNumericType InNumericType) {}
	///<summary>NumericType</summary>
	public ECommonNumericType NumericType;
	///<summary>The specifications for how the current numeric value should be formatted in to numeral text.</summary>
	public FCommonNumberFormattingOptions FormattingSpecification;
	///<summary>Exponent parameter for the &quot;ease out&quot; interpolation curve. Must be &gt; 0, but should be &gt; 1 in order to &quot;ease out&quot;.</summary>
	public float EaseOutInterpolationExponent;
	///<summary>The desired interval, in seconds, between interpolation updates. 0.0 implies per-frame updates. NOTE: Interpolation updates may occur further apart due to tick rates.</summary>
	public float InterpolationUpdateInterval;
	///<summary>The desired width of the formatted text may change rapidly and erratically during interpolation due to font glyph dimensions.</summary>
	public float PostInterpolationShrinkDuration;
	///<summary>PerformSizeInterpolation</summary>
	public bool PerformSizeInterpolation;
	///<summary>Should the current numeric value be presented as a percentage? IE: 1.0 -&gt; &quot;100%&quot;</summary>
	public bool IsPercentage_DEPRECATED;
}
