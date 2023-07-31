#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning various field related nodes (nodes associated with</summary>
[CppInclude("BlueprintFieldNodeSpawner.h")]
public partial class UBlueprintFieldNodeSpawner : UBlueprintNodeSpawner {
	///<summary>The owning class to configure new nodes with.</summary>
	public UClass OwnerClass;
	///<summary>The field to configure new nodes with.</summary>
	public UField Field;
	///<summary>Property</summary>
	public object Property;
}
