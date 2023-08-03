#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that uses 1 DMX channel</summary>
[CppInclude("DMXFixtureComponentSingle.h")]
public partial class UDMXFixtureComponentSingle : UDMXFixtureComponent {
	public static UClass StaticClass() {return default;}
	///<summary>DMXChannel</summary>
	public FDMXChannelData DMXChannel;
	///<summary>Gets the interpolation delta value (step) for this frame</summary>
	public  float GetDMXInterpolatedStep() { return default; }
	///<summary>Gets the current interpolated value</summary>
	public  float GetDMXInterpolatedValue() { return default; }
	///<summary>Gets the target value towards which the component interpolates</summary>
	public  float GetDMXTargetValue() { return default; }
	///<summary>True if the target value is reached and no interpolation is required</summary>
	public  bool IsDMXInterpolationDone() { return default; }
	///<summary>Called to set the value. When interpolation is enabled this function is called by the plugin until the target value is reached, else just once.</summary>
	public  void SetValueNoInterp(float NewValue) {}
}
