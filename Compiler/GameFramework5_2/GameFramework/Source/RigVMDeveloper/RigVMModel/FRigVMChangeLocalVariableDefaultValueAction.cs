#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to change the default value of a local variable.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMChangeLocalVariableDefaultValueAction {
	public FRigVMGraphVariableDescription LocalVariable;
	public string DefaultValue;
}
