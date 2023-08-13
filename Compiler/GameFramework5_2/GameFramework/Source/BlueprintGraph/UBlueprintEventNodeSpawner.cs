namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning UK2Node_Event nodes. Acts as the &quot;action&quot; portion of</summary>
[CppInclude("BlueprintEventNodeSpawner.h")]
public partial class UBlueprintEventNodeSpawner : UBlueprintNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The function to configure new nodes with.</summary>
	public UFunction EventFunc;
	///<summary>The custom name to configure new event nodes with.</summary>
	public string CustomEventName;
}
