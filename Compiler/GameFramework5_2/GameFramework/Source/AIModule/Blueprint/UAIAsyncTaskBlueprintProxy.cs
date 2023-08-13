namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AIAsyncTaskBlueprintProxy.h")]
public partial class UAIAsyncTaskBlueprintProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OnSuccess</summary>
	public FOAISimpleDelegate OnSuccess;
	///<summary>OnFail</summary>
	public FOAISimpleDelegate OnFail;
	///<summary>OnMoveCompleted</summary>
	public void OnMoveCompleted(FAIRequestID RequestID,EPathFollowingResult MovementResult) {}
}
