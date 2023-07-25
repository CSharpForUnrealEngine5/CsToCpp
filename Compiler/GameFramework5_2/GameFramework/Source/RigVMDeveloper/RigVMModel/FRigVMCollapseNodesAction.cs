#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to collapse a selection of nodes</summary>
public partial struct FRigVMCollapseNodesAction {
// RigVMCollapseNodesAction
	public string LibraryNodePath;
	public string CollapsedNodesContent;
	public TArray<string> CollapsedNodesPaths;
	public TArray<string> CollapsedNodesLinks;
	public bool bIsAggregate;
}
