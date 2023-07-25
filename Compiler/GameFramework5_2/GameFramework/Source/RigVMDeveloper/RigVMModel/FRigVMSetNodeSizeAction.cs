#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a node's size in the graph.</summary>
public partial struct FRigVMSetNodeSizeAction {
// RigVMSetNodeSizeAction
	public string NodePath;
	public FVector2D OldSize;
	public FVector2D NewSize;
}
