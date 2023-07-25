#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InstancedStaticMeshComponent.h")]
///<summary>Helper class used to preserve lighting/selection state across blueprint reinstancing</summary>
public partial struct FInstancedStaticMeshComponentInstanceData {
// InstancedStaticMeshComponentInstanceData
	public UStaticMesh StaticMesh;
	public FInstancedStaticMeshLightMapInstanceData CachedStaticLighting;
	public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData;
	public TArray<float> PerInstanceSMCustomData;
	public int InstancingRandomSeed;
	public TArray<FInstancedStaticMeshRandomSeed> AdditionalRandomSeeds;
	public bool bHasPerInstanceHitProxies;
}
