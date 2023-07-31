#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for Blueprint based evaluators.</summary>
[CppInclude("Blueprint/StateTreeEvaluatorBlueprintBase.h")]
public partial class UStateTreeEvaluatorBlueprintBase : UStateTreeNodeBlueprintBase {
	///<summary>ReceiveTreeStart</summary>
	public  void ReceiveTreeStart() {}
	///<summary>ReceiveTreeStop</summary>
	public  void ReceiveTreeStop() {}
	///<summary>ReceiveTick</summary>
	public  void ReceiveTick(float DeltaTime) {}
}
