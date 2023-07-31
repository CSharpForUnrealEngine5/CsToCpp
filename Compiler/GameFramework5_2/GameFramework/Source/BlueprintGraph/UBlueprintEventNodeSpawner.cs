#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning UK2Node_Event nodes. Acts as the &quot;action&quot; portion of</summary>
[CppInclude("BlueprintEventNodeSpawner.h")]
public partial class UBlueprintEventNodeSpawner : UBlueprintNodeSpawner {
	///<summary>The function to configure new nodes with.</summary>
	public UFunction EventFunc;
	///<summary>The custom name to configure new event nodes with.</summary>
	public string CustomEventName;
}
