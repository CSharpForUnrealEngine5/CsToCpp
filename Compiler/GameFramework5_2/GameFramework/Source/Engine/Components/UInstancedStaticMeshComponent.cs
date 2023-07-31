#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that efficiently renders multiple instances of the same StaticMesh.</summary>
[CppInclude("Components/InstancedStaticMeshComponent.h")]
public partial class UInstancedStaticMeshComponent : UStaticMeshComponent {
	///<summary>Array of instances, bulk serialized.</summary>
	public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData;
	///<summary>Array of prev instance transforms. Must match the length of PerInstanceSMData or have 0 elements</summary>
	public TArray<FMatrix> PerInstancePrevTransform;
	///<summary>Defines the number of floats that will be available per instance for custom data</summary>
	public int NumCustomDataFloats;
	///<summary>Array of custom data for instances. This will contains NumCustomDataFloats*InstanceCount entries. The entries are represented sequantially, in instance order. Can be read in a material and manipulated through Blueprints.</summary>
	public TArray<float> PerInstanceSMCustomData;
	///<summary>Value used to seed the random number stream that generates random numbers for each of this mesh&#39;s instances.</summary>
	public int InstancingRandomSeed;
	///<summary>Additional random seeds ranges. Each seed entry will be applied from AdditionalRandomSeeds[i].StartInstanceIndex to AdditionalRandomSeeds[i+1].StartInstanceIndex -1</summary>
	public TArray<FInstancedStaticMeshRandomSeed> AdditionalRandomSeeds;
	///<summary>Distance from camera at which each instance begins to fade out.</summary>
	public int InstanceStartCullDistance;
	///<summary>Distance from camera at which each instance completely fades out.</summary>
	public int InstanceEndCullDistance;
	///<summary>Mapping from PerInstanceSMData order to instance render buffer order. If empty, the PerInstanceSMData order is used.</summary>
	public TArray<int> InstanceReorderTable;
	///<summary>Add an instance to this component. Transform is given in local space of this component unless bWorldSpace is set.</summary>
	public  int AddInstance(FTransform InstanceTransform,bool bWorldSpace/*=false*/) { return default; }
	///<summary>Add multiple instances to this component. Transform is given in local space of this component unless bWorldSpace is set.</summary>
	public  TArray<int> AddInstances(TArray<FTransform> InstanceTransforms,bool bShouldReturnIndices,bool bWorldSpace/*=false*/) { return default; }
	///<summary>AddInstanceWorldSpace</summary>
	public  int AddInstanceWorldSpace(FTransform WorldTransform) { return default; }
	///<summary>Update custom data for specific instance</summary>
	public  bool SetCustomDataValue(int InstanceIndex,int CustomDataIndex,float CustomDataValue,bool bMarkRenderStateDirty/*=false*/) { return default; }
	///<summary>Get the transform for the instance specified. Instance is returned in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
	public  bool GetInstanceTransform(int InstanceIndex,FTransform OutInstanceTransform,bool bWorldSpace/*=false*/) { return default; }
	///<summary>Update the transform for the instance specified.</summary>
	public  bool UpdateInstanceTransform(int InstanceIndex,FTransform NewInstanceTransform,bool bWorldSpace/*=false*/,bool bMarkRenderStateDirty/*=false*/,bool bTeleport/*=false*/) { return default; }
	///<summary>Update the transform for an array of instances.</summary>
	public  bool BatchUpdateInstancesTransforms(int StartInstanceIndex,TArray<FTransform> NewInstancesTransforms,bool bWorldSpace/*=false*/,bool bMarkRenderStateDirty/*=false*/,bool bTeleport/*=false*/) { return default; }
	///<summary>Update the transform for a number of instances.</summary>
	public  bool BatchUpdateInstancesTransform(int StartInstanceIndex,int NumInstances,FTransform NewInstancesTransform,bool bWorldSpace/*=false*/,bool bMarkRenderStateDirty/*=false*/,bool bTeleport/*=false*/) { return default; }
	///<summary>Remove the instance specified. Returns True on success.</summary>
	public  bool RemoveInstance(int InstanceIndex) { return default; }
	///<summary>Remove the instances specified. Returns True on success.</summary>
	public  bool RemoveInstances(TArray<int> InstancesToRemove) { return default; }
	///<summary>Clear all instances being rendered by this component.</summary>
	public  void ClearInstances() {}
	///<summary>Get the number of instances in this component.</summary>
	public  int GetInstanceCount() { return default; }
	///<summary>Does the given index map to a valid instance in this component?</summary>
	public  bool IsValidInstance(int InstanceIndex) { return default; }
	///<summary>Sets the fading start and culling end distances for this component.</summary>
	public  void SetCullDistances(int StartCullDistance,int EndCullDistance) {}
	///<summary>Returns the instances with instance bounds overlapping the specified sphere. The return value is an array of instance indices.</summary>
	public  TArray<int> GetInstancesOverlappingSphere(FVector Center,float Radius,bool bSphereInWorldSpace/*=true*/) { return default; }
	///<summary>Returns the instances with instance bounds overlapping the specified box. The return value is an array of instance indices.</summary>
	public  TArray<int> GetInstancesOverlappingBox(FBox Box,bool bBoxInWorldSpace/*=true*/) { return default; }
	///<summary>Number of pending lightmaps still to be calculated (Apply()&#39;d).</summary>
	public int NumPendingLightmaps;
	///<summary>The mappings for all the instances of this component.</summary>
	public TArray<FInstancedStaticMeshMappingInfo> CachedMappings;
}
