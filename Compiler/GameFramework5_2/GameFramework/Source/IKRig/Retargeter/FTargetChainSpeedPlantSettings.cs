#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FTargetChainSpeedPlantSettings {
// TargetChainSpeedPlantSettings
	public bool EnableSpeedPlanting;
	public string SpeedCurveName;
	public float SpeedThreshold;
	public float UnplantStiffness;
	public float UnplantCriticalDamping;
}
