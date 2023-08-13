namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that holds the data necessary to set up a default set of limb controls for a character</summary>
[CppInclude("PhysicsControlActor.h")]
public partial struct FInitialCharacterControls {
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
