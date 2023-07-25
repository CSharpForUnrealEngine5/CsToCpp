#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to change the type of a local variable.</summary>
public partial struct FRigVMChangeLocalVariableTypeAction {
// RigVMChangeLocalVariableTypeAction
	public FRigVMGraphVariableDescription LocalVariable;
	public string CPPType;
	public UObject CPPTypeObject;
}
