#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsAssetRenderUtils.h")]
///<summary>Factory class for FPhysicsAssetRenderSettings.</summary>
public partial class UPhysicsAssetRenderUtilities : UObject {
// PhysicsAssetRenderUtilities
	public TMap<uint,FPhysicsAssetRenderSettings> IdToSettingsMap;
	public UMaterialInterface BoneUnselectedMaterial;
	public UMaterialInterface BoneNoCollisionMaterial;
}
