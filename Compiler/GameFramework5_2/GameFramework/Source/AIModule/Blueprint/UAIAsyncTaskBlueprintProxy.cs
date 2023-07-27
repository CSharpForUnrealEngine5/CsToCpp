#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AIAsyncTaskBlueprintProxy.h")]
public partial class UAIAsyncTaskBlueprintProxy : UObject {
// AIAsyncTaskBlueprintProxy
	public FOAISimpleDelegate OnSuccess;
	public FOAISimpleDelegate OnFail;
	public  void OnMoveCompleted(FAIRequestID RequestID,EPathFollowingResult MovementResult) {}
}
