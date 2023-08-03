#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hardware targeting settings, stored in default config, per-project</summary>
[CppInclude("HardwareTargetingSettings.h")]
public partial class UHardwareTargetingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enum specifying which class of hardware this game is targeting</summary>
	public EHardwareClass TargetedHardwareClass;
	///<summary>Enum that is set to TargetedHardwareClass when the settings have been successfully applied</summary>
	public EHardwareClass AppliedTargetedHardwareClass;
	///<summary>Enum specifying a graphics preset to use for this game</summary>
	public EGraphicsPreset DefaultGraphicsPerformance;
	///<summary>Enum that is set to DefaultGraphicsPerformance when the settings have been successfully applied</summary>
	public EGraphicsPreset AppliedDefaultGraphicsPerformance;
}
