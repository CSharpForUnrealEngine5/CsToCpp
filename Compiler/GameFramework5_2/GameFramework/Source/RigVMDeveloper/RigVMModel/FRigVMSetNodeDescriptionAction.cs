#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a node's description in the graph.</summary>
public partial struct FRigVMSetNodeDescriptionAction {
// RigVMSetNodeDescriptionAction
	public string NodePath;
	public string OldDescription;
	public string NewDescription;
}
