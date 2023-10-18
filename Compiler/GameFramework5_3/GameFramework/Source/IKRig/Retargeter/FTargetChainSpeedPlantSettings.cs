namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FTargetChainSpeedPlantSettings {
	public bool EnableSpeedPlanting;
	public FName SpeedCurveName;
	public float SpeedThreshold;
	public float UnplantStiffness;
	public float UnplantCriticalDamping;
}
