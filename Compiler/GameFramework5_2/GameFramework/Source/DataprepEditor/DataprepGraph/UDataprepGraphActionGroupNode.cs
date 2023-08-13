namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGraph/DataprepGraphActionNode.h")]
public partial class UDataprepGraphActionGroupNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>ExecutionOrder</summary>
	public int ExecutionOrder;
	///<summary>NodeTitle</summary>
	public string NodeTitle;
	///<summary>Actions</summary>
	public TArray<UDataprepActionAsset> Actions;
	///<summary>DataprepAssetPtr</summary>
	public TWeakObjectPtr<UDataprepAsset> DataprepAssetPtr;
}
