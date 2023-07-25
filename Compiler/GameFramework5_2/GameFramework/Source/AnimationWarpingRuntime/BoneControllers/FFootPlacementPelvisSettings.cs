#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_FootPlacement.h")]
public partial struct FFootPlacementPelvisSettings {
// FootPlacementPelvisSettings
	public float MaxOffset;
	public float LinearStiffness;
	public float LinearDamping;
	public float HorizontalRebalancingWeight;
	public float MaxOffsetHorizontal;
	public float HeelLiftRatio;
	public EPelvisHeightMode PelvisHeightMode;
	public EActorMovementCompensationMode ActorMovementCompensationMode;
	public bool bEnableInterpolation;
}
