#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to change the default value of a local variable.</summary>
public partial struct FRigVMChangeLocalVariableDefaultValueAction {
// RigVMChangeLocalVariableDefaultValueAction
	public FRigVMGraphVariableDescription LocalVariable;
	public string DefaultValue;
}
