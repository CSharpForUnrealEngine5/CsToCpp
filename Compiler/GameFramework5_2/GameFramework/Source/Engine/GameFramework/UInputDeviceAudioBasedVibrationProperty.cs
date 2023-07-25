#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceProperties.h")]
///<summary>Plays a sound to an input device's speaker. On platforms that support it, this sound will be played</summary>
public partial class UInputDeviceAudioBasedVibrationProperty : UInputDeviceProperty {
// InputDeviceAudioBasedVibrationProperty
	public FAudioBasedVibrationData Data;
	public TMap<string,FAudioBasedVibrationData> DeviceOverrideData;
}
