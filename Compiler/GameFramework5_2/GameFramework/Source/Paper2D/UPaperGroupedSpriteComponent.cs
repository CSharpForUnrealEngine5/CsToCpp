#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that handles rendering and collision for many instances of one or more UPaperSprite assets.</summary>
[CppInclude("PaperGroupedSpriteComponent.h")]
public partial class UPaperGroupedSpriteComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Array of materials used by the instances</summary>
	public TArray<UMaterialInterface> InstanceMaterials;
	///<summary>Array of instances</summary>
	public TArray<FSpriteInstanceData> PerInstanceSpriteData;
	///<summary>Add an instance to this component. Transform can be given either in the local space of this component or world space.</summary>
	public  int AddInstance(FTransform Transform,UPaperSprite Sprite,bool bWorldSpace/*=false*/,FLinearColor Color/*=FLinearColor.White*/) { return default; }
	///<summary>Get the transform for the instance specified. Instance is returned in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
	public  bool GetInstanceTransform(int InstanceIndex,FTransform OutInstanceTransform,bool bWorldSpace/*=false*/) { return default; }
	///<summary>Update the transform for the instance specified. Instance is given in local space of this component unless bWorldSpace is set.  Returns True on success.</summary>
	public  bool UpdateInstanceTransform(int InstanceIndex,FTransform NewInstanceTransform,bool bWorldSpace/*=false*/,bool bMarkRenderStateDirty/*=true*/,bool bTeleport/*=false*/) { return default; }
	///<summary>Update the color for the instance specified. Returns True on success.</summary>
	public  bool UpdateInstanceColor(int InstanceIndex,FLinearColor NewInstanceColor,bool bMarkRenderStateDirty/*=true*/) { return default; }
	///<summary>Remove the instance specified. Returns True on success.</summary>
	public  bool RemoveInstance(int InstanceIndex) { return default; }
	///<summary>Clear all instances being rendered by this component</summary>
	public  void ClearInstances() {}
	///<summary>Get the number of instances in this component</summary>
	public  int GetInstanceCount() { return default; }
	///<summary>Sort all instances by their world space position along the specified axis</summary>
	public  void SortInstancesAlongAxis(FVector WorldSpaceSortAxis) {}
}
