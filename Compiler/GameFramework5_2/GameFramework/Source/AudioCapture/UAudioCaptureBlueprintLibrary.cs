#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioCaptureBlueprintLibrary.h")]
public partial class UAudioCaptureBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>Returns the device info in a human readable format</summary>
	public static string Conv_AudioInputDeviceInfoToString(FAudioInputDeviceInfo info) { return default; }
	///<summary>Gets information about all audio output devices available in the system</summary>
	public static void GetAvailableAudioInputDevices(UObject WorldContextObject,FOnAudioInputDevicesObtained OnObtainDevicesEvent) {}
}
