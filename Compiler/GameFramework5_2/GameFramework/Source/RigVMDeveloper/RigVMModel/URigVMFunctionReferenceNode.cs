#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMFunctionReferenceNode.h")]
///<summary>The Function Reference Node is a library node which references</summary>
public partial class URigVMFunctionReferenceNode : URigVMLibraryNode {
// RigVMFunctionReferenceNode
	public FRigVMGraphFunctionHeader ReferencedFunctionHeader;
	public TSoftObjectPtr<URigVMLibraryNode> ReferencedNodePtr_DEPRECATED;
	public TMap<string,string> VariableMap;
}
