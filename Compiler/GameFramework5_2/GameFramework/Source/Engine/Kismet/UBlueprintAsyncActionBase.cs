namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>BlueprintCallable factory functions for classes which inherit from UBlueprintAsyncActionBase will have a special blueprint node created for it: UK2Node_AsyncAction</summary>
[CppInclude("Kismet/BlueprintAsyncActionBase.h")]
public partial class UBlueprintAsyncActionBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called to trigger the action once the delegates have been bound</summary>
	public virtual void Activate() {}
}
