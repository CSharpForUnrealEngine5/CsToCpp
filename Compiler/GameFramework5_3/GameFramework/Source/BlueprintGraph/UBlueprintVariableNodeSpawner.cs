namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning variable getter/setter nodes. Serves as the &quot;action&quot;</summary>
[CppInclude("BlueprintVariableNodeSpawner.h")]
public partial class UBlueprintVariableNodeSpawner : UBlueprintFieldNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The graph that the local variable belongs to (if this is a local variable spawner).</summary>
	public UEdGraph LocalVarOuter;
	///<summary>LocalVarDesc</summary>
	public FBPVariableDescription LocalVarDesc;
}
