namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>base class for asynchronous actions that can be spawned from UK2Node_AsyncAction or C++ code.</summary>
[CppInclude("Engine/CancellableAsyncAction.h")]
public partial class UCancellableAsyncAction : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>Cancel an asynchronous action, this attempts to cancel any lower level processes and also prevents delegates from being fired</summary>
	public virtual void Cancel() {}
	///<summary>Returns true if this action is still active and has not completed or been cancelled</summary>
	public virtual bool IsActive() { return default; }
}
