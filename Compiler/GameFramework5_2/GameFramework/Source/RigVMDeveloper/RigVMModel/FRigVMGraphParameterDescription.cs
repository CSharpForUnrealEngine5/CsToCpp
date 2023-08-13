namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The parameter description is used to convey information</summary>
[CppInclude("RigVMModel/Nodes/RigVMParameterNode.h")]
public partial struct FRigVMGraphParameterDescription {
	public string Name;
	public bool bIsInput;
	public string CPPType;
	public UObject CPPTypeObject;
	public string DefaultValue;
}
