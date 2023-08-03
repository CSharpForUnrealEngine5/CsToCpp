#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface used to collide against static meshes - whether it is the mesh distance field or a physics asset&#39;s collision primitive</summary>
[CppInclude("NiagaraDataInterfaceRigidMeshCollisionQuery.h")]
public partial class UNiagaraDataInterfaceRigidMeshCollisionQuery : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Tag_DEPRECATED</summary>
	public string Tag_DEPRECATED;
	///<summary>Set of tags used to match against actors when searching for RigidBody providers.  Empty tags will be ignored, and only a single</summary>
	public TArray<string> ActorTags;
	///<summary>Set of tags used to match against components when searching for RigidBody providers.  Empty tags will be ignored, and only a</summary>
	public TArray<string> ComponentTags;
	///<summary>Hardcoded references to actors that will be used as RigidBody providers.</summary>
	public TArray<TSoftObjectPtr<AActor>> SourceActors;
	///<summary>If enabled only actors that are considered moveable will be searched for RigidBodies.</summary>
	public bool OnlyUseMoveable;
	///<summary>If enabled, complex collisions will be searched for.</summary>
	public bool UseComplexCollisions;
	///<summary>GlobalSearchAllowed</summary>
	public bool GlobalSearchAllowed;
	///<summary>GlobalSearchForced</summary>
	public bool GlobalSearchForced;
	///<summary>GlobalSearchFallback_Unscripted</summary>
	public bool GlobalSearchFallback_Unscripted;
	///<summary>Maximum number of RigidBody represented by this DataInterface.</summary>
	public int MaxNumPrimitives;
}
