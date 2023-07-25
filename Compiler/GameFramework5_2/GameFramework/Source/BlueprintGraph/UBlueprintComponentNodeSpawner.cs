#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintComponentNodeSpawner.h")]
///<summary>Takes care of spawning UK2Node_AddComponent nodes. Acts as the "action"</summary>
public partial class UBlueprintComponentNodeSpawner : UBlueprintNodeSpawner {
// BlueprintComponentNodeSpawner
	public UClass ComponentClass;
	public string ComponentName;
	public string ComponentAssetName;
}
