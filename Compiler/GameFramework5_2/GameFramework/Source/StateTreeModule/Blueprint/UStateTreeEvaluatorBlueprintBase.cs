#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/StateTreeEvaluatorBlueprintBase.h")]
///<summary>* Base class for Blueprint based evaluators.</summary>
public partial class UStateTreeEvaluatorBlueprintBase : UStateTreeNodeBlueprintBase {
// StateTreeEvaluatorBlueprintBase
	public  void ReceiveTreeStart() {}
	public  void ReceiveTreeStop() {}
	public  void ReceiveTick(float DeltaTime) {}
}
