#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a node's position in the graph.</summary>
public partial struct FRigVMSetNodePositionAction {
// RigVMSetNodePositionAction
	public string NodePath;
	public FVector2D OldPosition;
	public FVector2D NewPosition;
}
