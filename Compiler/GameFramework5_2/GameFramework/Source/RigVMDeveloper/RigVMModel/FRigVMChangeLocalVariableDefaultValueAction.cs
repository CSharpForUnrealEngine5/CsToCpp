namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to change the default value of a local variable.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMChangeLocalVariableDefaultValueAction {
	public FRigVMGraphVariableDescription LocalVariable;
	public string DefaultValue;
}
