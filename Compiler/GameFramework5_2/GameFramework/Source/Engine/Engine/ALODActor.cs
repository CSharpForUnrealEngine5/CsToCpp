#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LODActor.h")]
///<summary>LODActor is an instance of an autogenerated StaticMesh Actors by Hierarchical LOD System</summary>
public partial class ALODActor : AActor {
// LODActor
	public UStaticMeshComponent StaticMeshComponent;
	public TMap<FHLODInstancingKey,UInstancedStaticMeshComponent> InstancedStaticMeshComponents;
	public UHLODProxy Proxy;
	public string Key;
	public float LODDrawDistance;
	public int LODLevel;
	public TArray<AActor> SubActors;
	public byte CachedNumHLODLevels;
	public uint NumTrianglesInSubActors;
	public uint NumTrianglesInMergedMesh;
	public bool bOverrideMaterialMergeSettings;
	public FMaterialProxySettings MaterialSettings;
	public bool bOverrideTransitionScreenSize;
	public float TransitionScreenSize;
	public bool bOverrideScreenSize;
	public int ScreenSize;
	public  void OnSubActorEndPlay(AActor Actor,EEndPlayReason Reason) {}
	public string LODActorTag;
	public bool bBuiltFromHLODDesc;
	public UHLODProxyDesc ProxyDesc;
}
