#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEventNodeSpawner.h")]
///<summary>Takes care of spawning UK2Node_Event nodes. Acts as the "action" portion of</summary>
public partial class UBlueprintEventNodeSpawner : UBlueprintNodeSpawner {
// BlueprintEventNodeSpawner
	public UFunction EventFunc;
	public string CustomEventName;
}
