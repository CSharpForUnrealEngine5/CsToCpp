#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlActor.h")]
///<summary>Structure that holds the data necessary to set up a default set of limb controls for a character</summary>
public partial struct FInitialCharacterControls {
// InitialCharacterControls
	public AActor CharacterActor;
	public string SkeletalMeshComponentName;
	public TArray<FPhysicsControlLimbSetupData> LimbSetupData;
	public FPhysicsControlData WorldSpaceControlData;
	public FPhysicsControlSettings WorldSpaceControlSettings;
	public bool bEnableWorldSpaceControls;
	public FPhysicsControlData ParentSpaceControlData;
	public FPhysicsControlSettings ParentSpaceControlSettings;
	public bool bEnableParentSpaceControls;
	public EPhysicsMovementType PhysicsMovementType;
}
