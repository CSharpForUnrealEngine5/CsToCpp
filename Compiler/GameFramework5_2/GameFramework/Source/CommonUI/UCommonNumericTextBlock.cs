#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonNumericTextBlock.h")]
///<summary>Numeric text block that provides interpolation, and some type support (numbers, percents, seconds, distance).</summary>
public partial class UCommonNumericTextBlock : UCommonTextBlock {
// CommonNumericTextBlock
	public  float GetTargetValue() { return default; }
	public  void SetCurrentValue(float NewValue) {}
	public  void InterpolateToValue(float TargetValue,float MaximumInterpolationDuration/*=3.0f*/,float MinimumChangeRate/*=1.0f*/,float OutroOffset/*=0.0f*/) {}
	public  bool IsInterpolatingNumericValue() { return default; }
	public  void FOnInterpolationStarted(UCommonNumericTextBlock NumericTextBlock) {}
	public FOnInterpolationStarted OnInterpolationStartedEvent;
	public  void FOnInterpolationUpdated(UCommonNumericTextBlock NumericTextBlock,float LastValue,float NewValue) {}
	public FOnInterpolationUpdated OnInterpolationUpdatedEvent;
	public  void FOnOutro(UCommonNumericTextBlock NumericTextBlock) {}
	public FOnOutro OnOutroEvent;
	public  void FOnInterpolationEnded(UCommonNumericTextBlock NumericTextBlock,bool HadCompleted) {}
	public FOnInterpolationEnded OnInterpolationEndedEvent;
	public float CurrentNumericValue;
	public  void SetNumericType(ECommonNumericType InNumericType) {}
	public ECommonNumericType NumericType;
	public FCommonNumberFormattingOptions FormattingSpecification;
	public float EaseOutInterpolationExponent;
	public float InterpolationUpdateInterval;
	public float PostInterpolationShrinkDuration;
	public bool PerformSizeInterpolation;
	public bool IsPercentage_DEPRECATED;
}
