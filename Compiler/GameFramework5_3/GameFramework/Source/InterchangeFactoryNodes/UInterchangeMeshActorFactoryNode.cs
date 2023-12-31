namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeMeshActorFactoryNode.h")]
public partial class UInterchangeMeshActorFactoryNode : UInterchangeActorFactoryNode {
	public static UClass StaticClass() {return default;}
	///<summary>Allow to retrieve the correspondence table between slot names and assigned materials for this object.</summary>
	public void GetSlotMaterialDependencies(TMap<string,string> OutMaterialDependencies) {}
	///<summary>Allow to retrieve one Material dependency for a given slot of this object.</summary>
	public bool GetSlotMaterialDependencyUid(string SlotName,string OutMaterialDependency) { return default; }
	///<summary>Add one Material dependency to a specific slot name of this object.</summary>
	public bool SetSlotMaterialDependencyUid(string SlotName,string MaterialDependencyUid) { return default; }
	///<summary>Remove the Material dependency associated with the given slot name from this object.</summary>
	public bool RemoveSlotMaterialDependencyUid(string SlotName) { return default; }
	///<summary>Set the Animation Asset To Play by this Scene Node. (only relevant for SkeletalMeshActors (SceneNodes that are instantiating Skeletal Meshes))</summary>
	public bool SetCustomAnimationAssetUidToPlay(string AttributeValue) { return default; }
	///<summary>Get the Animation Asset To Play by this Scene Node.</summary>
	public bool GetCustomAnimationAssetUidToPlay(string AttributeValue) { return default; }
	///<summary>Get the geometric offset. Any mesh attach to this scene node will be offset using this transform.</summary>
	public bool GetCustomGeometricTransform(FTransform AttributeValue) { return default; }
	///<summary>Set the geometric offset. Any mesh attach to this scene node will be offset using this transform.</summary>
	public bool SetCustomGeometricTransform(FTransform AttributeValue) { return default; }
}
