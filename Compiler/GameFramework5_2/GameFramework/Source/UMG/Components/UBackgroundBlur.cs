#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BackgroundBlur.h")]
///<summary>A background blur is a container widget that can contain one child widget, providing an opportunity</summary>
public partial class UBackgroundBlur : UContentWidget {
// BackgroundBlur
	public FMargin Padding;
	public EHorizontalAlignment HorizontalAlignment;
	public EVerticalAlignment VerticalAlignment;
	public bool bApplyAlphaToBlur;
	public float BlurStrength;
	public bool bOverrideAutoRadiusCalculation;
	public int BlurRadius;
	public FVector4 CornerRadius;
	public FSlateBrush LowQualityFallbackBrush;
	public  void SetPadding(FMargin InPadding) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	public  void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur) {}
	public  void SetBlurRadius(int InBlurRadius) {}
	public  void SetBlurStrength(float InStrength) {}
	public  void SetCornerRadius(FVector4 InCornerRadius) {}
	public  void SetLowQualityFallbackBrush(FSlateBrush InBrush) {}
}
