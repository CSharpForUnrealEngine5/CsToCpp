#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a node&#39;s color in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodeColorAction {
	public string NodePath;
	public FLinearColor OldColor;
	public FLinearColor NewColor;
}
