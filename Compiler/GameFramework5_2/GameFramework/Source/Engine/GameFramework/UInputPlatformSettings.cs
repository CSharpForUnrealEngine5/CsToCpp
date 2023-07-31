#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-Platform input options</summary>
[CppInclude("GameFramework/InputSettings.h")]
public partial class UInputPlatformSettings : UPlatformSettings {
	///<summary>Returns an array of Hardware device names from every registered platform ini.</summary>
	public static TArray<string> GetAllHardwareDeviceNames() { return default; }
	///<summary>The maximum position that a trigger can be set to</summary>
	public int MaxTriggerFeedbackPosition;
	///<summary>The maximum strength that trigger feedback can be set to</summary>
	public int MaxTriggerFeedbackStrength;
	///<summary>The max position that a vibration trigger effect can be set to.</summary>
	public int MaxTriggerVibrationTriggerPosition;
	///<summary>The max frequency that a trigger vibration can occur</summary>
	public int MaxTriggerVibrationFrequency;
	///<summary>The maximum amplitude that can be set on trigger vibrations</summary>
	public int MaxTriggerVibrationAmplitude;
	///<summary>A list of identifiable hardware devices available on this platform</summary>
	public TArray<FHardwareDeviceIdentifier> HardwareDevices;
}
