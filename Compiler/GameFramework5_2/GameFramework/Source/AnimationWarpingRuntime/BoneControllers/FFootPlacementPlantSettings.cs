#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_FootPlacement.h")]
public partial struct FFootPlacementPlantSettings {
	public float SpeedThreshold;
	public float DistanceToGround;
	public EFootPlacementLockType LockType;
	public float UnplantRadius;
	public float ReplantRadiusRatio;
	public float UnplantAngle;
	public float ReplantAngleRatio;
	public float MaxExtensionRatio;
	public float MinExtensionRatio;
	public float SeparatingDistance;
	public float UnalignmentSpeedThreshold;
	public float AnkleTwistReduction;
	public bool bAdjustHeelBeforePlanting;
}
