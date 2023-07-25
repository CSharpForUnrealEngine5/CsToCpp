#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CancellableAsyncAction.h")]
///<summary>base class for asynchronous actions that can be spawned from UK2Node_AsyncAction or C++ code.</summary>
public partial class UCancellableAsyncAction : UBlueprintAsyncActionBase {
// CancellableAsyncAction
	public void Cancel() {}
	public bool IsActive() { return default; }
}
