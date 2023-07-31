#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The UDataprepGraphActionNode class is used as the UEdGraphNode associated</summary>
[CppInclude("DataprepGraph/DataprepGraphActionNode.h")]
public partial class UDataprepGraphActionNode : UEdGraphNode {
	///<summary>ActionTitle</summary>
	public string ActionTitle;
	///<summary>DataprepActionAsset</summary>
	public UDataprepActionAsset DataprepActionAsset;
	///<summary>DataprepAssetPtr</summary>
	public TWeakObjectPtr<UDataprepAsset> DataprepAssetPtr;
	///<summary>ExecutionOrder</summary>
	public int ExecutionOrder;
}
