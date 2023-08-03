#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SkeletalMeshActor is an instance of a USkeletalMesh in the world.</summary>
[CppInclude("Animation/SkeletalMeshActor.h")]
public partial class ASkeletalMeshActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not this actor should respond to anim notifies - CURRENTLY ONLY AFFECTS PlayParticleEffect NOTIFIES*</summary>
	public bool bShouldDoAnimNotifies;
	///<summary>bWakeOnLevelStart_DEPRECATED</summary>
	public bool bWakeOnLevelStart_DEPRECATED;
	///<summary>SkeletalMeshComponent</summary>
	public USkeletalMeshComponent SkeletalMeshComponent;
	///<summary>Used to replicate mesh to clients</summary>
	public USkeletalMesh ReplicatedMesh;
	///<summary>Used to replicate physics asset to clients</summary>
	public UPhysicsAsset ReplicatedPhysAsset;
	///<summary>used to replicate the material in index 0</summary>
	public UMaterialInterface ReplicatedMaterial0;
	///<summary>ReplicatedMaterial1</summary>
	public UMaterialInterface ReplicatedMaterial1;
	///<summary>Replication Notification Callbacks</summary>
	public  void OnRep_ReplicatedMesh() {}
	///<summary>OnRep_ReplicatedPhysAsset</summary>
	public  void OnRep_ReplicatedPhysAsset() {}
	///<summary>OnRep_ReplicatedMaterial0</summary>
	public  void OnRep_ReplicatedMaterial0() {}
	///<summary>OnRep_ReplicatedMaterial1</summary>
	public  void OnRep_ReplicatedMaterial1() {}
}
