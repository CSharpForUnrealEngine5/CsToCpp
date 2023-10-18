namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to change the type of a local variable.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMChangeLocalVariableTypeAction {
	public FRigVMGraphVariableDescription LocalVariable;
	public string CPPType;
	public UObject CPPTypeObject;
}
