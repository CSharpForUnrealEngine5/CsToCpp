namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning various field related nodes (nodes associated with</summary>
[CppInclude("BlueprintFieldNodeSpawner.h")]
public partial class UBlueprintFieldNodeSpawner : UBlueprintNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The owning class to configure new nodes with.</summary>
	public UClass OwnerClass;
	///<summary>The field to configure new nodes with.</summary>
	public UField Field;
	///<summary>Property</summary>
	public object Property;
}
