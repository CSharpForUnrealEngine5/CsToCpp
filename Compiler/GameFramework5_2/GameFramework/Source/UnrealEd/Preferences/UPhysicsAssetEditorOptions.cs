#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/PhysicsAssetEditorOptions.h")]
public partial class UPhysicsAssetEditorOptions : UObject {
// PhysicsAssetEditorOptions
	public float PhysicsBlend;
	public bool bUpdateJointsFromAnimation;
	public byte PhysicsUpdateMode;
	public float PokePauseTime;
	public float PokeBlendTime;
	public float GravScale;
	public float GravityOverrideZ;
	public bool bUseGravityOverride;
	public int MaxFPS;
	public float HandleLinearDamping;
	public float HandleLinearStiffness;
	public float HandleAngularDamping;
	public float HandleAngularStiffness;
	public float InterpolationSpeed;
	public float PokeStrength;
	public float InteractionDistance;
	public bool bShowConstraintsAsPoints;
	public bool bRenderOnlySelectedConstraints;
	public bool bSimulationFloorCollisionEnabled;
	public float ConstraintDrawSize;
	public EPhysicsAssetEditorMeshViewMode MeshViewMode;
	public EPhysicsAssetEditorCollisionViewMode CollisionViewMode;
	public EPhysicsAssetEditorConstraintViewMode ConstraintViewMode;
	public EPhysicsAssetEditorMeshViewMode SimulationMeshViewMode;
	public EPhysicsAssetEditorCollisionViewMode SimulationCollisionViewMode;
	public EPhysicsAssetEditorConstraintViewMode SimulationConstraintViewMode;
	public float CollisionOpacity;
	public bool bSolidRenderingForSelectedOnly;
	public bool bHideSimulatedBodies;
	public bool bHideKinematicBodies;
	public bool bResetClothWhenSimulating;
}
