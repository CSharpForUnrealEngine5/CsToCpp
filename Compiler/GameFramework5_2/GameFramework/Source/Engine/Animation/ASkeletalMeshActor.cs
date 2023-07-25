#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/SkeletalMeshActor.h")]
///<summary>SkeletalMeshActor is an instance of a USkeletalMesh in the world.</summary>
public partial class ASkeletalMeshActor : AActor {
// SkeletalMeshActor
	public bool bShouldDoAnimNotifies;
	public bool bWakeOnLevelStart_DEPRECATED;
	public USkeletalMeshComponent SkeletalMeshComponent;
	public USkeletalMesh ReplicatedMesh;
	public UPhysicsAsset ReplicatedPhysAsset;
	public UMaterialInterface ReplicatedMaterial0;
	public UMaterialInterface ReplicatedMaterial1;
	public void OnRep_ReplicatedMesh() {}
	public void OnRep_ReplicatedPhysAsset() {}
	public void OnRep_ReplicatedMaterial0() {}
	public void OnRep_ReplicatedMaterial1() {}
}
