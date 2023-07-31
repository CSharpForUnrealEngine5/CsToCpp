#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGraph/DataprepGraphActionNode.h")]
public partial class UDataprepGraphActionGroupNode : UEdGraphNode {
	///<summary>ExecutionOrder</summary>
	public int ExecutionOrder;
	///<summary>NodeTitle</summary>
	public string NodeTitle;
	///<summary>Actions</summary>
	public TArray<UDataprepActionAsset> Actions;
	///<summary>DataprepAssetPtr</summary>
	public TWeakObjectPtr<UDataprepAsset> DataprepAssetPtr;
}
