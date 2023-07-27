#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureComponentSingle.h")]
///<summary>Component that uses 1 DMX channel</summary>
public partial class UDMXFixtureComponentSingle : UDMXFixtureComponent {
// DMXFixtureComponentSingle
	public FDMXChannelData DMXChannel;
	public  float GetDMXInterpolatedStep() { return default; }
	public  float GetDMXInterpolatedValue() { return default; }
	public  float GetDMXTargetValue() { return default; }
	public  bool IsDMXInterpolationDone() { return default; }
	public  void SetValueNoInterp(float NewValue) {}
}
