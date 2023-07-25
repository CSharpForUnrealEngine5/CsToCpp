#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a node's color in the graph.</summary>
public partial struct FRigVMSetNodeColorAction {
// RigVMSetNodeColorAction
	public string NodePath;
	public FLinearColor OldColor;
	public FLinearColor NewColor;
}
