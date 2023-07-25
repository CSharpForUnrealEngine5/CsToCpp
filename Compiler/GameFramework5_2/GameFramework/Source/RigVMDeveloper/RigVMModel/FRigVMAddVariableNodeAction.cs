#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action adding a variable node to the graph.</summary>
public partial struct FRigVMAddVariableNodeAction {
// RigVMAddVariableNodeAction
	public string VariableName;
	public string CPPType;
	public string CPPTypeObjectPath;
	public bool bIsGetter;
	public string DefaultValue;
	public FVector2D Position;
	public string NodePath;
}
