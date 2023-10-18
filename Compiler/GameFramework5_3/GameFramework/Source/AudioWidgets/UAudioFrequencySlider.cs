namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An audio slider widget, for use with frequency.</summary>
[CppInclude("AudioSlider.h")]
public partial class UAudioFrequencySlider : UAudioSliderBase {
	public static UClass StaticClass() {return default;}
	///<summary>Frequency output range</summary>
	public FVector2D OutputRange;
}
