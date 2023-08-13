namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A C++ and Blueprint accessible library of utility functions for accessing Niagara simulations</summary>
[CppInclude("NiagaraFunctionLibrary.h")]
public partial class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>SpawnSystemAtLocationWithParams</summary>
	public static UNiagaraComponent SpawnSystemAtLocationWithParams(FFXSystemSpawnParameters SpawnParams) { return default; }
	///<summary>SpawnSystemAttachedWithParams</summary>
	public static UNiagaraComponent SpawnSystemAttachedWithParams(FFXSystemSpawnParameters SpawnParams) { return default; }
	///<summary>Spawns a Niagara System at the specified world location/rotation</summary>
	public static UNiagaraComponent SpawnSystemAtLocation(UObject WorldContextObject,UNiagaraSystem SystemTemplate,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,bool bAutoDestroy/*=true*/,bool bAutoActivate/*=true*/,ENCPoolMethod PoolingMethod/*=ENCPoolMethod.None*/,bool bPreCullCheck/*=true*/) { return default; }
	///<summary>SpawnSystemAttached</summary>
	public static UNiagaraComponent SpawnSystemAttached(UNiagaraSystem SystemTemplate,USceneComponent AttachToComponent,string AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType,bool bAutoDestroy,bool bAutoActivate/*=true*/,ENCPoolMethod PoolingMethod/*=ENCPoolMethod.None*/,bool bPreCullCheck/*=true*/) { return default; }
	///<summary>Sets a Niagara StaticMesh parameter by name, overriding locally if necessary.</summary>
	public static void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent NiagaraSystem,string OverrideName,UStaticMeshComponent StaticMeshComponent) {}
	///<summary>OverrideSystemUserVariableStaticMesh</summary>
	public static void OverrideSystemUserVariableStaticMesh(UNiagaraComponent NiagaraSystem,string OverrideName,UStaticMesh StaticMesh) {}
	///<summary>Sets a Niagara StaticMesh parameter by name, overriding locally if necessary.</summary>
	public static void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent NiagaraSystem,string OverrideName,USkeletalMeshComponent SkeletalMeshComponent) {}
	///<summary>Sets the SamplingRegion to use on the skeletal mesh data interface, this is destructive as it modifies the data interface.</summary>
	public static void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<string> SamplingRegions) {}
	///<summary>Sets the Filtered Bones to use on the skeletal mesh data interface, this is destructive as it modifies the data interface.</summary>
	public static void SetSkeletalMeshDataInterfaceFilteredBones(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<string> FilteredBones) {}
	///<summary>Sets the Filtered Sockets to use on the skeletal mesh data interface, this is destructive as it modifies the data interface.</summary>
	public static void SetSkeletalMeshDataInterfaceFilteredSockets(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<string> FilteredSockets) {}
	///<summary>Overrides the Texture Object for a Niagara Texture Data Interface User Parameter.</summary>
	public static void SetTextureObject(UNiagaraComponent NiagaraSystem,string OverrideName,UTexture Texture) {}
	///<summary>Overrides the 2D Array Texture for a Niagara 2D Array Texture Data Interface User Parameter.</summary>
	public static void SetTexture2DArrayObject(UNiagaraComponent NiagaraSystem,string OverrideName,UTexture2DArray Texture) {}
	///<summary>Overrides the Volume Texture for a Niagara Volume Texture Data Interface User Parameter.</summary>
	public static void SetVolumeTextureObject(UNiagaraComponent NiagaraSystem,string OverrideName,UVolumeTexture Texture) {}
	///<summary>This is gonna be totally reworked</summary>
	public static UNiagaraParameterCollectionInstance GetNiagaraParameterCollection(UObject WorldContextObject,UNiagaraParameterCollection Collection) { return default; }
	///<summary>Sets the Niagara GPU ray traced collision group for the give primitive component.</summary>
	public static void SetComponentNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,UPrimitiveComponent Primitive,int CollisionGroup) {}
	///<summary>Sets the Niagara GPU ray traced collision group for all primitive components on the given actor.</summary>
	public static void SetActorNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,AActor Actor,int CollisionGroup) {}
	///<summary>Returns a free collision group for use in HWRT collision group filtering. Returns -1 on failure.</summary>
	public static int AcquireNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject) { return default; }
	///<summary>Releases a collision group back to the system for use by ohers.</summary>
	public static void ReleaseNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,int CollisionGroup) {}
}
