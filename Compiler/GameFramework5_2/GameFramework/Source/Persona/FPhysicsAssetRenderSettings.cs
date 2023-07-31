#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per Physics Asset parameters that determine how debug draw functions</summary>
[CppInclude("PhysicsAssetRenderUtils.h")]
public partial struct FPhysicsAssetRenderSettings {
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
