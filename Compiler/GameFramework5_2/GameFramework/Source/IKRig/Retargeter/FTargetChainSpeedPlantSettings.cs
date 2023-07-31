#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FTargetChainSpeedPlantSettings {
	public bool EnableSpeedPlanting;
	public string SpeedCurveName;
	public float SpeedThreshold;
	public float UnplantStiffness;
	public float UnplantCriticalDamping;
}
