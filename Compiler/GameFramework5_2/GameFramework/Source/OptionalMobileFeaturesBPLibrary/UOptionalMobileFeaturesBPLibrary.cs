#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptionalMobileFeaturesBPLibrary.h")]
public partial class UOptionalMobileFeaturesBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the current volume state of the device in a range of 0-100 (%)</summary>
	public static int GetVolumeState() { return default; }
	///<summary>Returns the current battery level of the device in a range of [0, 100]</summary>
	public static int GetBatteryLevel() { return default; }
	///<summary>Returns the device&#39;s temperature, in Celsius</summary>
	public static float GetBatteryTemperature() { return default; }
	///<summary>Returns if headphones are plugged into the device</summary>
	public static bool AreHeadphonesPluggedIn() { return default; }
}
