namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMBuildData.h")]
public partial struct FRigVMReferenceNodeData {
	public string ReferenceNodePath;
	public string ReferencedFunctionPath_DEPRECATED;
	public FRigVMGraphFunctionHeader ReferencedHeader_DEPRECATED;
	public FRigVMGraphFunctionIdentifier ReferencedFunctionIdentifier;
}
