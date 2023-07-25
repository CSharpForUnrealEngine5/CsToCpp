#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGraph/DataprepGraphActionNode.h")]
public partial class UDataprepGraphActionGroupNode : UEdGraphNode {
// DataprepGraphActionGroupNode
	public int ExecutionOrder;
	public string NodeTitle;
	public TArray<UDataprepActionAsset> Actions;
	public TWeakObjectPtr<UDataprepAsset> DataprepAssetPtr;
}
