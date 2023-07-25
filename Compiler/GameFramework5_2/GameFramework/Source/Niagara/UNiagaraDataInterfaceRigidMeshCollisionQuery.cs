#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRigidMeshCollisionQuery.h")]
///<summary>Data Interface used to collide against static meshes - whether it is the mesh distance field or a physics asset's collision primitive</summary>
public partial class UNiagaraDataInterfaceRigidMeshCollisionQuery : UNiagaraDataInterface {
// NiagaraDataInterfaceRigidMeshCollisionQuery
	public string Tag_DEPRECATED;
	public TArray<string> ActorTags;
	public TArray<string> ComponentTags;
	public TArray<TSoftObjectPtr<AActor>> SourceActors;
	public bool OnlyUseMoveable;
	public bool UseComplexCollisions;
	public bool GlobalSearchAllowed;
	public bool GlobalSearchForced;
	public bool GlobalSearchFallback_Unscripted;
	public int MaxNumPrimitives;
}
