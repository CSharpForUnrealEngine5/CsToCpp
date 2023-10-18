namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncRegisterAndExecuteTask.h")]
public partial class UAsyncRegisterAndExecuteTask : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>RegisterAndExecuteTask</summary>
	public static UAsyncRegisterAndExecuteTask RegisterAndExecuteTask(UEditorUtilityTask Task,UEditorUtilityTask OptionalParentTask/*=nullptr*/) { return default; }
	///<summary>OnFinished</summary>
	public FOnEditorUtilityTaskDynamicDelegate OnFinished;
}
