namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Intended to be wrapped and used by FBlueprintActionMenuItem. Rather than</summary>
[CppInclude("BlueprintNodeSpawner.h")]
public partial class UBlueprintNodeSpawner : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Holds the node type that this spawner will instantiate.</summary>
	public UClass NodeClass;
}
