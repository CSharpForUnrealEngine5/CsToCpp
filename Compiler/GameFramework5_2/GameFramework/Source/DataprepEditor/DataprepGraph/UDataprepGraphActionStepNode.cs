namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The UDataprepGraphActionStepNode class is used as the UEdGraphNode associated</summary>
[CppInclude("DataprepGraph/DataprepGraphActionNode.h")]
public partial class UDataprepGraphActionStepNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>DataprepActionAsset</summary>
	public UDataprepActionAsset DataprepActionAsset;
	///<summary>StepIndex</summary>
	public int StepIndex;
}
