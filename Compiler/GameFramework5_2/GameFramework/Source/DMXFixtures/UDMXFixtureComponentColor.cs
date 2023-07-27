#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureComponentColor.h")]
///<summary>Specific class to handle color mixing using 4 channels (rgb, cmy, rgbw).</summary>
public partial class UDMXFixtureComponentColor : UDMXFixtureComponent {
// DMXFixtureComponentColor
	public FDMXAttributeName DMXChannel1;
	public FDMXAttributeName DMXChannel2;
	public FDMXAttributeName DMXChannel3;
	public FDMXAttributeName DMXChannel4;
	public  void SetColorNoInterp(FLinearColor NewColor) {}
}
