#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsAssetEditorSkeletalMeshComponent.h")]
public partial class UPhysicsAssetEditorSkeletalMeshComponent : UDebugSkelMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Materials</summary>
	public UMaterialInstanceDynamic ElemSelectedMaterial;
	///<summary>BoneUnselectedMaterial</summary>
	public UMaterialInstanceDynamic BoneUnselectedMaterial;
	///<summary>BoneNoCollisionMaterial</summary>
	public UMaterialInstanceDynamic BoneNoCollisionMaterial;
	///<summary>BoneMaterialHit</summary>
	public UMaterialInterface BoneMaterialHit;
}
