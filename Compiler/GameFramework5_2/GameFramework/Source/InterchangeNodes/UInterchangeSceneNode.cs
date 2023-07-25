#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeSceneNode.h")]
///<summary>The scene node represent a transform node in the scene</summary>
public partial class UInterchangeSceneNode : UInterchangeBaseNode {
// InterchangeSceneNode
	public bool IsSpecializedTypeContains(string SpecializedType) { return default; }
	public int GetSpecializedTypeCount() { return default; }
	public void GetSpecializedType(int Index,string OutSpecializedType) {}
	public void GetSpecializedTypes(TArray<string> OutSpecializedTypes) {}
	public bool AddSpecializedType(string SpecializedType) { return default; }
	public bool RemoveSpecializedType(string SpecializedType) { return default; }
	public bool GetCustomAssetInstanceUid(string AttributeValue) { return default; }
	public bool SetCustomAssetInstanceUid(string AttributeValue) { return default; }
	public bool GetCustomLocalTransform(FTransform AttributeValue) { return default; }
	public bool SetCustomLocalTransform(UObject BaseNodeContainer,FTransform AttributeValue,bool bResetCache/*=true*/) { return default; }
	public bool GetCustomGlobalTransform(UObject BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache/*=false*/) { return default; }
	public bool GetCustomGeometricTransform(FTransform AttributeValue) { return default; }
	public bool SetCustomGeometricTransform(FTransform AttributeValue) { return default; }
	public bool GetCustomBindPoseLocalTransform(FTransform AttributeValue) { return default; }
	public bool SetCustomBindPoseLocalTransform(UObject BaseNodeContainer,FTransform AttributeValue,bool bResetCache/*=true*/) { return default; }
	public bool GetCustomBindPoseGlobalTransform(UObject BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache/*=false*/) { return default; }
	public bool GetCustomTimeZeroLocalTransform(FTransform AttributeValue) { return default; }
	public bool SetCustomTimeZeroLocalTransform(UObject BaseNodeContainer,FTransform AttributeValue,bool bResetCache/*=true*/) { return default; }
	public bool GetCustomTimeZeroGlobalTransform(UObject BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache/*=false*/) { return default; }
	public void GetSlotMaterialDependencies(TMap<string,string> OutMaterialDependencies) {}
	public bool GetSlotMaterialDependencyUid(string SlotName,string OutMaterialDependency) { return default; }
	public bool SetSlotMaterialDependencyUid(string SlotName,string MaterialDependencyUid) { return default; }
	public bool RemoveSlotMaterialDependencyUid(string SlotName) { return default; }
}
