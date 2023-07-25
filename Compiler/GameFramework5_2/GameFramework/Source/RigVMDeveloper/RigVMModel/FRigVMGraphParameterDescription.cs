#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMParameterNode.h")]
///<summary>The parameter description is used to convey information</summary>
public partial struct FRigVMGraphParameterDescription {
// RigVMGraphParameterDescription
	public string Name;
	public bool bIsInput;
	public string CPPType;
	public UObject CPPTypeObject;
	public string DefaultValue;
}
