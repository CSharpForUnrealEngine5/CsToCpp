#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial struct FMutableRefSkeletalMeshData {
// MutableRefSkeletalMeshData
	public TSoftObjectPtr<USkeleton> Skeleton;
	public TSoftObjectPtr<UPhysicsAsset> PhysicsAsset;
	public TSoftObjectPtr<UClass> PostProcessAnimInst;
	public TSoftObjectPtr<UPhysicsAsset> ShadowPhysicsAsset;
}
