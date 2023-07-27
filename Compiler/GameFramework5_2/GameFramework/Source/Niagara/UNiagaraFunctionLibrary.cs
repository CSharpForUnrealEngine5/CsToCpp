#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraFunctionLibrary.h")]
///<summary>A C++ and Blueprint accessible library of utility functions for accessing Niagara simulations</summary>
public partial class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary {
// NiagaraFunctionLibrary
	public static UNiagaraComponent SpawnSystemAtLocationWithParams(FFXSystemSpawnParameters SpawnParams) { return default; }
	public static UNiagaraComponent SpawnSystemAttachedWithParams(FFXSystemSpawnParameters SpawnParams) { return default; }
	public static UNiagaraComponent SpawnSystemAtLocation(UObject WorldContextObject,UNiagaraSystem SystemTemplate,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,bool bAutoDestroy/*=true*/,bool bAutoActivate/*=true*/,ENCPoolMethod PoolingMethod/*=ENCPoolMethod.None*/,bool bPreCullCheck/*=true*/) { return default; }
	public static UNiagaraComponent SpawnSystemAttached(UNiagaraSystem SystemTemplate,USceneComponent AttachToComponent,string AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType,bool bAutoDestroy,bool bAutoActivate/*=true*/,ENCPoolMethod PoolingMethod/*=ENCPoolMethod.None*/,bool bPreCullCheck/*=true*/) { return default; }
	public static void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent NiagaraSystem,string OverrideName,UStaticMeshComponent StaticMeshComponent) {}
	public static void OverrideSystemUserVariableStaticMesh(UNiagaraComponent NiagaraSystem,string OverrideName,UStaticMesh StaticMesh) {}
	public static void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent NiagaraSystem,string OverrideName,USkeletalMeshComponent SkeletalMeshComponent) {}
	public static void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<string> SamplingRegions) {}
	public static void SetSkeletalMeshDataInterfaceFilteredBones(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<string> FilteredBones) {}
	public static void SetSkeletalMeshDataInterfaceFilteredSockets(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<string> FilteredSockets) {}
	public static void SetTextureObject(UNiagaraComponent NiagaraSystem,string OverrideName,UTexture Texture) {}
	public static void SetTexture2DArrayObject(UNiagaraComponent NiagaraSystem,string OverrideName,UTexture2DArray Texture) {}
	public static void SetVolumeTextureObject(UNiagaraComponent NiagaraSystem,string OverrideName,UVolumeTexture Texture) {}
	public static UNiagaraParameterCollectionInstance GetNiagaraParameterCollection(UObject WorldContextObject,UNiagaraParameterCollection Collection) { return default; }
	public static void SetComponentNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,UPrimitiveComponent Primitive,int CollisionGroup) {}
	public static void SetActorNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,AActor Actor,int CollisionGroup) {}
	public static int AcquireNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject) { return default; }
	public static void ReleaseNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,int CollisionGroup) {}
}
