#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Function Reference Node is a library node which references</summary>
[CppInclude("RigVMModel/Nodes/RigVMFunctionReferenceNode.h")]
public partial class URigVMFunctionReferenceNode : URigVMLibraryNode {
	///<summary>void SetReferencedFunctionData(FRigVMGraphFunctionData* Data);</summary>
	public FRigVMGraphFunctionHeader ReferencedFunctionHeader;
	///<summary>ReferencedNodePtr_DEPRECATED</summary>
	public TSoftObjectPtr<URigVMLibraryNode> ReferencedNodePtr_DEPRECATED;
	///<summary>VariableMap</summary>
	public TMap<string,string> VariableMap;
}
