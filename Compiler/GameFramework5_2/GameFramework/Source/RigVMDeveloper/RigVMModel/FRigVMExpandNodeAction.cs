#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to expand a library node into its content</summary>
public partial struct FRigVMExpandNodeAction {
// RigVMExpandNodeAction
	public string LibraryNodePath;
	public string LibraryNodeContent;
	public TArray<string> LibraryNodeLinks;
	public TArray<string> ExpandedNodePaths;
}
