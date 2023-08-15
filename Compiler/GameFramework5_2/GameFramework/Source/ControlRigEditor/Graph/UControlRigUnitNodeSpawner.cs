namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/NodeSpawners/ControlRigUnitNodeSpawner.h")]
public partial class UControlRigUnitNodeSpawner : UBlueprintNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The unit type we will spawn</summary>
	public UScriptStruct StructTemplate;
	///<summary>MethodName</summary>
	public FName MethodName;
}
