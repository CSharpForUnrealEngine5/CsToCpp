namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for Blueprint based evaluators.</summary>
[CppInclude("Blueprint/StateTreeEvaluatorBlueprintBase.h")]
public partial class UStateTreeEvaluatorBlueprintBase : UStateTreeNodeBlueprintBase {
	public static UClass StaticClass() {return default;}
	///<summary>ReceiveTreeStart</summary>
	public void ReceiveTreeStart() {}
	///<summary>ReceiveTreeStop</summary>
	public void ReceiveTreeStop() {}
	///<summary>ReceiveTick</summary>
	public void ReceiveTick(float DeltaTime) {}
}
