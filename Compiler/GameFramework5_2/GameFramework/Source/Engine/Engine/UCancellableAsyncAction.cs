#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>base class for asynchronous actions that can be spawned from UK2Node_AsyncAction or C++ code.</summary>
[CppInclude("Engine/CancellableAsyncAction.h")]
public partial class UCancellableAsyncAction : UBlueprintAsyncActionBase {
	///<summary>Cancel an asynchronous action, this attempts to cancel any lower level processes and also prevents delegates from being fired</summary>
	public  void Cancel() {}
	///<summary>Returns true if this action is still active and has not completed or been cancelled</summary>
	public  bool IsActive() { return default; }
}
