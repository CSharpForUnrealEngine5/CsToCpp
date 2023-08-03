#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct is used to store and retrieve key value attributes. The attributes are store in a generic FAttributeStorage which serialize the value in a TArray64&lt;uint8&gt;</summary>
[CppInclude("Nodes/InterchangeBaseNode.h")]
public partial class UInterchangeBaseNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize the base data of the node</summary>
	public  void InitializeNode(string UniqueID,string DisplayLabel,EInterchangeNodeContainerType NodeContainerType) {}
	///<summary>Remove any attribute from this node. Return false if we cannot remove it. If the attribute do not exist it will return true.</summary>
	public  bool RemoveAttribute(string NodeAttributeKey) { return default; }
	///<summary>Add a boolean attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddBooleanAttribute(string NodeAttributeKey,bool Value) { return default; }
	///<summary>Get a boolean attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetBooleanAttribute(string NodeAttributeKey,bool OutValue) { return default; }
	///<summary>Add a int32 attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddInt32Attribute(string NodeAttributeKey,int Value) { return default; }
	///<summary>Get a int32 attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetInt32Attribute(string NodeAttributeKey,int OutValue) { return default; }
	///<summary>Add a float attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddFloatAttribute(string NodeAttributeKey,float Value) { return default; }
	///<summary>Get a float attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetFloatAttribute(string NodeAttributeKey,float OutValue) { return default; }
	///<summary>Add a double attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddDoubleAttribute(string NodeAttributeKey,double Value) { return default; }
	///<summary>Get a double attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetDoubleAttribute(string NodeAttributeKey,double OutValue) { return default; }
	///<summary>Add a string attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddStringAttribute(string NodeAttributeKey,string Value) { return default; }
	///<summary>Get a string attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetStringAttribute(string NodeAttributeKey,string OutValue) { return default; }
	///<summary>Add a guid attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddGuidAttribute(string NodeAttributeKey,FGuid Value) { return default; }
	///<summary>Get a guid attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetGuidAttribute(string NodeAttributeKey,FGuid OutValue) { return default; }
	///<summary>Add a FLinearColor attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddLinearColorAttribute(string NodeAttributeKey,FLinearColor Value) { return default; }
	///<summary>Get a FLinearColor attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetLinearColorAttribute(string NodeAttributeKey,FLinearColor OutValue) { return default; }
	///<summary>Add a Vector2 attribute to this node. Return false if the attribute do not exist or if we cannot add it</summary>
	public  bool AddVector2Attribute(string NodeAttributeKey,FVector2f Value) { return default; }
	///<summary>Get a Vector2 attribute from this node. Return false if the attribute do not exist</summary>
	public  bool GetVector2Attribute(string NodeAttributeKey,FVector2f OutValue) { return default; }
	///<summary>Return the unique id pass in the constructor.</summary>
	public  string GetUniqueID() { return default; }
	///<summary>Return the display label.</summary>
	public  string GetDisplayLabel() { return default; }
	///<summary>Change the display label.</summary>
	public  bool SetDisplayLabel(string DisplayName) { return default; }
	///<summary>Return the parent unique id. In case the attribute does not exist it will return InvalidNodeUid()</summary>
	public  string GetParentUid() { return default; }
	///<summary>SetParentUid</summary>
	public  bool SetParentUid(string ParentUid) { return default; }
	///<summary>Get number of target assets relating to this object.</summary>
	public  int GetTargetNodeCount() { return default; }
	///<summary>Get target assets relating to this object.</summary>
	public  void GetTargetNodeUids(TArray<string> OutTargetAssets) {}
	///<summary>Add asset node UID relating to this object.</summary>
	public  bool AddTargetNodeUid(string AssetUid) { return default; }
	///<summary>Remove asset node UID relating to this object.</summary>
	public  bool RemoveTargetNodeUid(string AssetUid) { return default; }
	///<summary>IsEnable true mean that the node will be import/export, if false it will be discarded.</summary>
	public  bool IsEnabled() { return default; }
	///<summary>Set the IsEnable attribute to determine if this node should be part of the import/export process</summary>
	public  bool SetEnabled(bool bIsEnabled) { return default; }
	///<summary>Return the node container type which define the purpose of the node (Factory node, translated scene node or translated asset node).</summary>
	public  EInterchangeNodeContainerType GetNodeContainerType() { return default; }
	///<summary>Optional, Any node that can import/export an asset should set the proper name we will give to the asset.</summary>
	public  string GetAssetName() { return default; }
	///<summary>Set the name we want for the imported asset this node represent. The asset factory will call GetAssetName()</summary>
	public  bool SetAssetName(string AssetName) { return default; }
}
