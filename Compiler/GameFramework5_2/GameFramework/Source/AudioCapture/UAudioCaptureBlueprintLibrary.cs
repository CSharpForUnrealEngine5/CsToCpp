namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioCaptureBlueprintLibrary.h")]
public partial class UAudioCaptureBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the device info in a human readable format</summary>
	public static string Conv_AudioInputDeviceInfoToString(FAudioInputDeviceInfo info) { return default; }
	///<summary>Gets information about all audio output devices available in the system</summary>
	public static void GetAvailableAudioInputDevices(UObject WorldContextObject,FOnAudioInputDevicesObtained OnObtainDevicesEvent) {}
}
