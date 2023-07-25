#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGraph/DataprepGraphActionNode.h")]
///<summary>The UDataprepGraphActionNode class is used as the UEdGraphNode associated</summary>
public partial class UDataprepGraphActionNode : UEdGraphNode {
// DataprepGraphActionNode
	public string ActionTitle;
	public UDataprepActionAsset DataprepActionAsset;
	public TWeakObjectPtr<UDataprepAsset> DataprepAssetPtr;
	public int ExecutionOrder;
}
