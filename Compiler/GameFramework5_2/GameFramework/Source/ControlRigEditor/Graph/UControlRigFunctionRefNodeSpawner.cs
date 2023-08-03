#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/NodeSpawners/ControlRigFunctionRefNodeSpawner.h")]
public partial class UControlRigFunctionRefNodeSpawner : UBlueprintNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The public function definition we will spawn from [optional]</summary>
	public FRigVMGraphFunctionHeader ReferencedPublicFunctionHeader;
	///<summary>Marked as true for local function definitions</summary>
	public bool bIsLocalFunction;
	///<summary>AssetPath</summary>
	public FSoftObjectPath AssetPath;
}
