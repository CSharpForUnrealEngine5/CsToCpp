namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/NodeSpawners/RigVMEdGraphFunctionRefNodeSpawner.h")]
public partial class URigVMEdGraphFunctionRefNodeSpawner : URigVMEdGraphNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The public function definition we will spawn from [optional]</summary>
	public FRigVMGraphFunctionHeader ReferencedPublicFunctionHeader;
	///<summary>Marked as true for local function definitions</summary>
	public bool bIsLocalFunction;
	///<summary>AssetPath</summary>
	public FSoftObjectPath AssetPath;
}
