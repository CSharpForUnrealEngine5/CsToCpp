#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HardwareTargetingSettings.h")]
///<summary>Hardware targeting settings, stored in default config, per-project</summary>
public partial class UHardwareTargetingSettings : UObject {
// HardwareTargetingSettings
	public EHardwareClass TargetedHardwareClass;
	public EHardwareClass AppliedTargetedHardwareClass;
	public EGraphicsPreset DefaultGraphicsPerformance;
	public EGraphicsPreset AppliedDefaultGraphicsPerformance;
}
