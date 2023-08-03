#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning UK2Node_AddComponent nodes. Acts as the &quot;action&quot;</summary>
[CppInclude("BlueprintComponentNodeSpawner.h")]
public partial class UBlueprintComponentNodeSpawner : UBlueprintNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The component class to configure new nodes with.</summary>
	public UClass ComponentClass;
	///<summary>The name of the component class to configure new nodes with.</summary>
	public string ComponentName;
	///<summary>The name of the asset name that needs to be loaded</summary>
	public string ComponentAssetName;
}
