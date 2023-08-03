#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that uses 2 DMX channels</summary>
[CppInclude("DMXFixtureComponentDouble.h")]
public partial class UDMXFixtureComponentDouble : UDMXFixtureComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The first dmx attribute the component handles</summary>
	public FDMXChannelData DMXChannel1;
	///<summary>The second dmx attribute the component handles</summary>
	public FDMXChannelData DMXChannel2;
	///<summary>Gets the interpolation delta value (step) for this frame</summary>
	public  float GetDMXInterpolatedStep(int ChannelIndex) { return default; }
	///<summary>Gets the current interpolated value</summary>
	public  float GetDMXInterpolatedValue(int ChannelIndex) { return default; }
	///<summary>Gets the target value towards which the component interpolates</summary>
	public  float GetDMXTargetValue(int ChannelIndex) { return default; }
	///<summary>True if the target value is reached and no interpolation is required</summary>
	public  bool IsDMXInterpolationDone(int ChannelIndex) { return default; }
	///<summary>Sets first value of the second channel. When interpolation is enabled this function should be called until the value is reached, else just once */</summary>
	public  void SetChannel1ValueNoInterp(float Channel1Value) {}
	///<summary>Sets second value of the second channel. When interpolation is enabled this function should be called until the value is reached, else just once</summary>
	public  void SetChannel2ValueNoInterp(float Channel2Value) {}
}
