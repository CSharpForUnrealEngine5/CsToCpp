namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class used to preserve lighting/selection state across blueprint reinstancing</summary>
[CppInclude("Components/InstancedStaticMeshComponent.h")]
public partial struct FInstancedStaticMeshComponentInstanceData {
	public UStaticMesh StaticMesh;
	public FInstancedStaticMeshLightMapInstanceData CachedStaticLighting;
	public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData;
	public TArray<float> PerInstanceSMCustomData;
	public int InstancingRandomSeed;
	public TArray<FInstancedStaticMeshRandomSeed> AdditionalRandomSeeds;
	public bool bHasPerInstanceHitProxies;
}
