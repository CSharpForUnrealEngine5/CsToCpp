#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A background blur is a container widget that can contain one child widget, providing an opportunity</summary>
[CppInclude("Components/BackgroundBlur.h")]
public partial class UBackgroundBlur : UContentWidget {
	///<summary>The padding area between the slot and the content it contains.</summary>
	public FMargin Padding;
	///<summary>The alignment of the content horizontally.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The alignment of the content vertically.</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>True to modulate the strength of the blur based on the widget alpha.</summary>
	public bool bApplyAlphaToBlur;
	///<summary>How blurry the background is.  Larger numbers mean more blurry but will result in larger runtime cost on the GPU.</summary>
	public float BlurStrength;
	///<summary>When OverrideAutoRadiusCalculation is set to true, BlurRadius is used for the radius of the blur. When false, it&#39;s automatically calculated using the BlurStength value.</summary>
	public bool bOverrideAutoRadiusCalculation;
	///<summary>This is the number of pixels which will be weighted in each direction from any given pixel when computing the blur</summary>
	public int BlurRadius;
	///<summary>This is the number of pixels which will be weighted in each direction from any given pixel when computing the blur</summary>
	public FVector4 CornerRadius;
	///<summary>An image to draw instead of applying a blur when low quality override mode is enabled.</summary>
	public FSlateBrush LowQualityFallbackBrush;
	///<summary>SetPadding</summary>
	public  void SetPadding(FMargin InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>SetVerticalAlignment</summary>
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
	///<summary>SetApplyAlphaToBlur</summary>
	public  void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur) {}
	///<summary>SetBlurRadius</summary>
	public  void SetBlurRadius(int InBlurRadius) {}
	///<summary>SetBlurStrength</summary>
	public  void SetBlurStrength(float InStrength) {}
	///<summary>SetCornerRadius</summary>
	public  void SetCornerRadius(FVector4 InCornerRadius) {}
	///<summary>SetLowQualityFallbackBrush</summary>
	public  void SetLowQualityFallbackBrush(FSlateBrush InBrush) {}
}
