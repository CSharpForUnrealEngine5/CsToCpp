namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The UDataprepGraphActionNode class is used as the UEdGraphNode associated</summary>
[CppInclude("DataprepGraph/DataprepGraphActionNode.h")]
public partial class UDataprepGraphActionNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>ActionTitle</summary>
	public string ActionTitle;
	///<summary>DataprepActionAsset</summary>
	public UDataprepActionAsset DataprepActionAsset;
	///<summary>DataprepAssetPtr</summary>
	public TWeakObjectPtr<UDataprepAsset> DataprepAssetPtr;
	///<summary>ExecutionOrder</summary>
	public int ExecutionOrder;
}
