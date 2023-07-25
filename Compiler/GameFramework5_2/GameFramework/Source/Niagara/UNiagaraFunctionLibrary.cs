#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraFunctionLibrary.h")]
///<summary>A C++ and Blueprint accessible library of utility functions for accessing Niagara simulations</summary>
public partial class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary {
// NiagaraFunctionLibrary
	public UObject SpawnSystemAtLocationWithParams(FFXSystemSpawnParameters SpawnParams) { return default; }
	public UObject SpawnSystemAttachedWithParams(FFXSystemSpawnParameters SpawnParams) { return default; }
	public UObject SpawnSystemAtLocation(UObject WorldContextObject,UObject SystemTemplate,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,bool bAutoDestroy/*=true*/,bool bAutoActivate/*=true*/,ENCPoolMethod PoolingMethod/*=ENCPoolMethod.None*/,bool bPreCullCheck/*=true*/) { return default; }
	public UObject SpawnSystemAttached(UObject SystemTemplate,UObject AttachToComponent,string AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType,bool bAutoDestroy,bool bAutoActivate/*=true*/,ENCPoolMethod PoolingMethod/*=ENCPoolMethod.None*/,bool bPreCullCheck/*=true*/) { return default; }
	public void OverrideSystemUserVariableStaticMeshComponent(UObject NiagaraSystem,string OverrideName,UObject StaticMeshComponent) {}
	public void OverrideSystemUserVariableStaticMesh(UObject NiagaraSystem,string OverrideName,UObject StaticMesh) {}
	public void OverrideSystemUserVariableSkeletalMeshComponent(UObject NiagaraSystem,string OverrideName,UObject SkeletalMeshComponent) {}
	public void SetSkeletalMeshDataInterfaceSamplingRegions(UObject NiagaraSystem,string OverrideName,TArray<string> SamplingRegions) {}
	public void SetSkeletalMeshDataInterfaceFilteredBones(UObject NiagaraSystem,string OverrideName,TArray<string> FilteredBones) {}
	public void SetSkeletalMeshDataInterfaceFilteredSockets(UObject NiagaraSystem,string OverrideName,TArray<string> FilteredSockets) {}
	public void SetTextureObject(UObject NiagaraSystem,string OverrideName,UObject Texture) {}
	public void SetTexture2DArrayObject(UObject NiagaraSystem,string OverrideName,UObject Texture) {}
	public void SetVolumeTextureObject(UObject NiagaraSystem,string OverrideName,UObject Texture) {}
	public UObject GetNiagaraParameterCollection(UObject WorldContextObject,UObject Collection) { return default; }
	public void SetComponentNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,UObject Primitive,int CollisionGroup) {}
	public void SetActorNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,UObject Actor,int CollisionGroup) {}
	public int AcquireNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject) { return default; }
	public void ReleaseNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,int CollisionGroup) {}
}
