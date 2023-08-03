#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An audio slider widget with customizable curves.</summary>
[CppInclude("AudioSlider.h")]
public partial class UAudioSlider : UAudioSliderBase {
	public static UClass StaticClass() {return default;}
	///<summary>Curves for mapping linear to output values.</summary>
	public TWeakObjectPtr<UCurveFloat> LinToOutputCurve;
	///<summary>OutputToLinCurve</summary>
	public TWeakObjectPtr<UCurveFloat> OutputToLinCurve;
}
