#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeBaseNode.h")]
///<summary>This struct is used to store and retrieve key value attributes. The attributes are store in a generic FAttributeStorage which serialize the value in a TArray64<uint8></summary>
public partial class UInterchangeBaseNode : UObject {
// InterchangeBaseNode
	public void InitializeNode(string UniqueID,string DisplayLabel,EInterchangeNodeContainerType NodeContainerType) {}
	public bool RemoveAttribute(string NodeAttributeKey) { return default; }
	public bool AddBooleanAttribute(string NodeAttributeKey,bool Value) { return default; }
	public bool GetBooleanAttribute(string NodeAttributeKey,bool OutValue) { return default; }
	public bool AddInt32Attribute(string NodeAttributeKey,int Value) { return default; }
	public bool GetInt32Attribute(string NodeAttributeKey,int OutValue) { return default; }
	public bool AddFloatAttribute(string NodeAttributeKey,float Value) { return default; }
	public bool GetFloatAttribute(string NodeAttributeKey,float OutValue) { return default; }
	public bool AddDoubleAttribute(string NodeAttributeKey,double Value) { return default; }
	public bool GetDoubleAttribute(string NodeAttributeKey,double OutValue) { return default; }
	public bool AddStringAttribute(string NodeAttributeKey,string Value) { return default; }
	public bool GetStringAttribute(string NodeAttributeKey,string OutValue) { return default; }
	public bool AddGuidAttribute(string NodeAttributeKey,FGuid Value) { return default; }
	public bool GetGuidAttribute(string NodeAttributeKey,FGuid OutValue) { return default; }
	public bool AddLinearColorAttribute(string NodeAttributeKey,FLinearColor Value) { return default; }
	public bool GetLinearColorAttribute(string NodeAttributeKey,FLinearColor OutValue) { return default; }
	public bool AddVector2Attribute(string NodeAttributeKey,FVector2f Value) { return default; }
	public bool GetVector2Attribute(string NodeAttributeKey,FVector2f OutValue) { return default; }
	public string GetUniqueID() { return default; }
	public string GetDisplayLabel() { return default; }
	public bool SetDisplayLabel(string DisplayName) { return default; }
	public string GetParentUid() { return default; }
	public bool SetParentUid(string ParentUid) { return default; }
	public int GetTargetNodeCount() { return default; }
	public void GetTargetNodeUids(TArray<string> OutTargetAssets) {}
	public bool AddTargetNodeUid(string AssetUid) { return default; }
	public bool RemoveTargetNodeUid(string AssetUid) { return default; }
	public bool IsEnabled() { return default; }
	public bool SetEnabled(bool bIsEnabled) { return default; }
	public EInterchangeNodeContainerType GetNodeContainerType() { return default; }
	public string GetAssetName() { return default; }
	public bool SetAssetName(string AssetName) { return default; }
}
