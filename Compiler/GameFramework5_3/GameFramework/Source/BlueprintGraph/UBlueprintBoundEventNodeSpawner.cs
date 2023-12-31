namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning UK2Node_Event nodes. Acts as the &quot;action&quot; portion of</summary>
[CppInclude("BlueprintBoundEventNodeSpawner.h")]
public partial class UBlueprintBoundEventNodeSpawner : UBlueprintEventNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>EventDelegate</summary>
	public object EventDelegate;
}
