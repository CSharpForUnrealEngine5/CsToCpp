namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding a variable node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddVariableNodeAction {
	public FName VariableName;
	public string CPPType;
	public string CPPTypeObjectPath;
	public bool bIsGetter;
	public string DefaultValue;
	public FVector2D Position;
	public string NodePath;
}
