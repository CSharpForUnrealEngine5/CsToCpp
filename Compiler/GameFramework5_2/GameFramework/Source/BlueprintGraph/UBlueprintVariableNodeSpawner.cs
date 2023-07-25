#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintVariableNodeSpawner.h")]
///<summary>Takes care of spawning variable getter/setter nodes. Serves as the "action"</summary>
public partial class UBlueprintVariableNodeSpawner : UBlueprintFieldNodeSpawner {
// BlueprintVariableNodeSpawner
	public UEdGraph LocalVarOuter;
	public FBPVariableDescription LocalVarDesc;
}
