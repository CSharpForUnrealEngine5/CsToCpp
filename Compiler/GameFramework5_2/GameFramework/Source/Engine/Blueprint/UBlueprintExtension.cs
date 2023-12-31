namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-instance extension object that can be added to UBlueprint::Extensions in order to augment built-in blueprint functionality</summary>
[CppInclude("Blueprint/BlueprintExtension.h")]
public partial class UBlueprintExtension : UObject {
	public static UClass StaticClass() {return default;}
}
