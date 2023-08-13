namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The variable description is used to convey information</summary>
[CppInclude("RigVMModel/RigVMVariableDescription.h")]
public partial struct FRigVMGraphVariableDescription {
	public string Name;
	public string CPPType;
	public UObject CPPTypeObject;
	public string DefaultValue;
}
