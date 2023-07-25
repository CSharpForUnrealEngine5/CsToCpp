#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioSlider.h")]
///<summary>An audio slider widget with customizable curves.</summary>
public partial class UAudioSlider : UAudioSliderBase {
// AudioSlider
	public TWeakObjectPtr<UCurveFloat> LinToOutputCurve;
	public TWeakObjectPtr<UCurveFloat> OutputToLinCurve;
}
