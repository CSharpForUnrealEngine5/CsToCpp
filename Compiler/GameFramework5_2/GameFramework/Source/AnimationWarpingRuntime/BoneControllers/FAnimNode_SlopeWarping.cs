#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_SlopeWarping.h")]
public partial struct FAnimNode_SlopeWarping {
// AnimNode_SlopeWarping
	public FBoneReference IKFootRootBone;
	public FBoneReference PelvisBone;
	public TArray<FSlopeWarpingFootDefinition> FeetDefinitions;
	public TArray<FSlopeWarpingFootData> FeetData;
	public FVectorRK4SpringInterpolator PelvisOffsetInterpolator;
	public FVector GravityDir;
	public FVector CustomFloorOffset;
	public float CachedDeltaTime;
	public FVector TargetFloorNormalWorldSpace;
	public FVectorRK4SpringInterpolator FloorNormalInterpolator;
	public FVector TargetFloorOffsetLocalSpace;
	public FVectorRK4SpringInterpolator FloorOffsetInterpolator;
	public float MaxStepHeight;
	public bool bKeepMeshInsideOfCapsule;
	public bool bPullPelvisDown;
	public bool bUseCustomFloorOffset;
	public bool bWasOnGround;
	public bool bShowDebug;
	public bool bFloorSmoothingInitialized;
	public FVector ActorLocation;
	public FVector GravityDirCompSpace;
}
