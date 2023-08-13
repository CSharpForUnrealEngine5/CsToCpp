namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The scene node represent a transform node in the scene</summary>
[CppInclude("InterchangeSceneNode.h")]
public partial class UInterchangeSceneNode : UInterchangeBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>IsSpecializedTypeContains</summary>
	public bool IsSpecializedTypeContains(string SpecializedType) { return default; }
	///<summary>Get the Specialized type this scene node represent (Joint, LODGroup, ...).</summary>
	public int GetSpecializedTypeCount() { return default; }
	///<summary>GetSpecializedType</summary>
	public void GetSpecializedType(int Index,string OutSpecializedType) {}
	///<summary>GetSpecializedTypes</summary>
	public void GetSpecializedTypes(TArray<string> OutSpecializedTypes) {}
	///<summary>AddSpecializedType</summary>
	public bool AddSpecializedType(string SpecializedType) { return default; }
	///<summary>RemoveSpecializedType</summary>
	public bool RemoveSpecializedType(string SpecializedType) { return default; }
	///<summary>Get which asset, if any, a scene node is instantiating. Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAssetInstanceUid(string AttributeValue) { return default; }
	///<summary>Add asset this scene node is instantiating</summary>
	public bool SetCustomAssetInstanceUid(string AttributeValue) { return default; }
	///<summary>Get the default scene node local transform.</summary>
	public bool GetCustomLocalTransform(FTransform AttributeValue) { return default; }
	///<summary>Set the default scene node local transform.</summary>
	public bool SetCustomLocalTransform(UInterchangeBaseNodeContainer BaseNodeContainer,FTransform AttributeValue,bool bResetCache/*=true*/) { return default; }
	///<summary>Get the default scene node global transform. This value is computed with all parent local transform.</summary>
	public bool GetCustomGlobalTransform(UInterchangeBaseNodeContainer BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache/*=false*/) { return default; }
	///<summary>Get the geometric offset. Any mesh attach to this scene node will be offset using this transform.</summary>
	public bool GetCustomGeometricTransform(FTransform AttributeValue) { return default; }
	///<summary>Set the geometric offset. Any mesh attach to this scene node will be offset using this transform.</summary>
	public bool SetCustomGeometricTransform(FTransform AttributeValue) { return default; }
	///<summary>Get the bind pose scene node local transform.</summary>
	public bool GetCustomBindPoseLocalTransform(FTransform AttributeValue) { return default; }
	///<summary>Set the bind pose scene node local transform.</summary>
	public bool SetCustomBindPoseLocalTransform(UInterchangeBaseNodeContainer BaseNodeContainer,FTransform AttributeValue,bool bResetCache/*=true*/) { return default; }
	///<summary>Get the bind pose scene node global transform. This value is computed with all parent bind pose local transform.</summary>
	public bool GetCustomBindPoseGlobalTransform(UInterchangeBaseNodeContainer BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache/*=false*/) { return default; }
	///<summary>Get the time zero scene node local transform.</summary>
	public bool GetCustomTimeZeroLocalTransform(FTransform AttributeValue) { return default; }
	///<summary>Set the time zero scene node local transform.</summary>
	public bool SetCustomTimeZeroLocalTransform(UInterchangeBaseNodeContainer BaseNodeContainer,FTransform AttributeValue,bool bResetCache/*=true*/) { return default; }
	///<summary>Get the time zero scene node global transform. This value is computed with all parent timezero local transform.</summary>
	public bool GetCustomTimeZeroGlobalTransform(UInterchangeBaseNodeContainer BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache/*=false*/) { return default; }
	///<summary>Allow to retrieve the correspondence table between slot names and assigned materials for this object.</summary>
	public void GetSlotMaterialDependencies(TMap<string,string> OutMaterialDependencies) {}
	///<summary>Allow to retrieve one Material dependency for a given slot of this object.</summary>
	public bool GetSlotMaterialDependencyUid(string SlotName,string OutMaterialDependency) { return default; }
	///<summary>Add one Material dependency to a specific slot name of this object.</summary>
	public bool SetSlotMaterialDependencyUid(string SlotName,string MaterialDependencyUid) { return default; }
	///<summary>Remove the Material dependency associated with the given slot name from this object.</summary>
	public bool RemoveSlotMaterialDependencyUid(string SlotName) { return default; }
}
