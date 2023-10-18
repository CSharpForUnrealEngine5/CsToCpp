namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Function Reference Node is a library node which references</summary>
[CppInclude("RigVMModel/Nodes/RigVMFunctionReferenceNode.h")]
public partial class URigVMFunctionReferenceNode : URigVMLibraryNode {
	public static UClass StaticClass() {return default;}
	///<summary>void SetReferencedFunctionData(FRigVMGraphFunctionData* Data);</summary>
	public FRigVMGraphFunctionHeader ReferencedFunctionHeader;
	///<summary>ReferencedNodePtr_DEPRECATED</summary>
	public TSoftObjectPtr<URigVMLibraryNode> ReferencedNodePtr_DEPRECATED;
	///<summary>VariableMap</summary>
	public TMap<FName,FName> VariableMap;
}
