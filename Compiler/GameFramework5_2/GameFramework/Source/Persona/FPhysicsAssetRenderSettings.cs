#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsAssetRenderUtils.h")]
///<summary>Per Physics Asset parameters that determine how debug draw functions</summary>
public partial struct FPhysicsAssetRenderSettings {
// PhysicsAssetRenderSettings
	public EPhysicsAssetEditorCollisionViewMode CollisionViewMode;
	public EPhysicsAssetEditorConstraintViewMode ConstraintViewMode;
	public EConstraintTransformComponentFlags ConstraintViewportManipulationFlags;
	public EConstraintTransformComponentFlags ConstraintTransformComponentDisplayRelativeToDefaultFlags;
	public float ConstraintDrawSize;
	public float PhysicsBlend;
	public bool bHideKinematicBodies;
	public bool bHideSimulatedBodies;
	public bool bRenderOnlySelectedConstraints;
	public bool bShowCOM;
	public bool bShowConstraintsAsPoints;
	public FColor BoneUnselectedColor;
	public FColor NoCollisionColor;
	public FColor COMRenderColor;
	public float COMRenderSize;
	public float InfluenceLineLength;
	public UMaterialInterface BoneUnselectedMaterial;
	public UMaterialInterface BoneNoCollisionMaterial;
	public TArray<int> HiddenBodies;
	public TArray<int> HiddenConstraints;
}
