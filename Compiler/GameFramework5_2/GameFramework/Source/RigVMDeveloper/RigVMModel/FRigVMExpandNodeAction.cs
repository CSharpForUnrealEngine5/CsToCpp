namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to expand a library node into its content</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMExpandNodeAction {
	public string LibraryNodePath;
	public string LibraryNodeContent;
	public TArray<string> LibraryNodeLinks;
	public TArray<string> ExpandedNodePaths;
}
