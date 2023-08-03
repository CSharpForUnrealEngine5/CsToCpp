#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Plays a sound to an input device&#39;s speaker. On platforms that support it, this sound will be played</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UInputDeviceAudioBasedVibrationProperty : UInputDeviceProperty {
	public static UClass StaticClass() {return default;}
	///<summary>Data</summary>
	public FAudioBasedVibrationData Data;
	///<summary>A map of device specific color data. If no overrides are specified, the Default hardware data will be used</summary>
	public TMap<string,FAudioBasedVibrationData> DeviceOverrideData;
}
