namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/NodeSpawners/RigVMEdGraphUnitNodeSpawner.h")]
public partial class URigVMEdGraphUnitNodeSpawner : URigVMEdGraphNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The unit type we will spawn</summary>
	public UScriptStruct StructTemplate;
	///<summary>MethodName</summary>
	public FName MethodName;
}
