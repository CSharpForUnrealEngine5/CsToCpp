#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InstancedStaticMeshComponent.h")]
///<summary>A component that efficiently renders multiple instances of the same StaticMesh.</summary>
public partial class UInstancedStaticMeshComponent : UStaticMeshComponent {
// InstancedStaticMeshComponent
	public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData;
	public TArray<FMatrix> PerInstancePrevTransform;
	public int NumCustomDataFloats;
	public TArray<float> PerInstanceSMCustomData;
	public int InstancingRandomSeed;
	public TArray<FInstancedStaticMeshRandomSeed> AdditionalRandomSeeds;
	public int InstanceStartCullDistance;
	public int InstanceEndCullDistance;
	public TArray<int> InstanceReorderTable;
	public  int AddInstance(FTransform InstanceTransform,bool bWorldSpace/*=false*/) { return default; }
	public  TArray<int> AddInstances(TArray<FTransform> InstanceTransforms,bool bShouldReturnIndices,bool bWorldSpace/*=false*/) { return default; }
	public  int AddInstanceWorldSpace(FTransform WorldTransform) { return default; }
	public  bool SetCustomDataValue(int InstanceIndex,int CustomDataIndex,float CustomDataValue,bool bMarkRenderStateDirty/*=false*/) { return default; }
	public  bool GetInstanceTransform(int InstanceIndex,FTransform OutInstanceTransform,bool bWorldSpace/*=false*/) { return default; }
	public  bool UpdateInstanceTransform(int InstanceIndex,FTransform NewInstanceTransform,bool bWorldSpace/*=false*/,bool bMarkRenderStateDirty/*=false*/,bool bTeleport/*=false*/) { return default; }
	public  bool BatchUpdateInstancesTransforms(int StartInstanceIndex,TArray<FTransform> NewInstancesTransforms,bool bWorldSpace/*=false*/,bool bMarkRenderStateDirty/*=false*/,bool bTeleport/*=false*/) { return default; }
	public  bool BatchUpdateInstancesTransform(int StartInstanceIndex,int NumInstances,FTransform NewInstancesTransform,bool bWorldSpace/*=false*/,bool bMarkRenderStateDirty/*=false*/,bool bTeleport/*=false*/) { return default; }
	public  bool RemoveInstance(int InstanceIndex) { return default; }
	public  bool RemoveInstances(TArray<int> InstancesToRemove) { return default; }
	public  void ClearInstances() {}
	public  int GetInstanceCount() { return default; }
	public  bool IsValidInstance(int InstanceIndex) { return default; }
	public  void SetCullDistances(int StartCullDistance,int EndCullDistance) {}
	public  TArray<int> GetInstancesOverlappingSphere(FVector Center,float Radius,bool bSphereInWorldSpace/*=true*/) { return default; }
	public  TArray<int> GetInstancesOverlappingBox(FBox Box,bool bBoxInWorldSpace/*=true*/) { return default; }
	public int NumPendingLightmaps;
	public TArray<FInstancedStaticMeshMappingInfo> CachedMappings;
}
