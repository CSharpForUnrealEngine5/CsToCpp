#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputSettings.h")]
///<summary>Per-Platform input options</summary>
public partial class UInputPlatformSettings : UPlatformSettings {
// InputPlatformSettings
	public static TArray<string> GetAllHardwareDeviceNames() { return default; }
	public int MaxTriggerFeedbackPosition;
	public int MaxTriggerFeedbackStrength;
	public int MaxTriggerVibrationTriggerPosition;
	public int MaxTriggerVibrationFrequency;
	public int MaxTriggerVibrationAmplitude;
	public TArray<FHardwareDeviceIdentifier> HardwareDevices;
}
