#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to collapse a selection of nodes</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMCollapseNodesAction {
	public string LibraryNodePath;
	public string CollapsedNodesContent;
	public TArray<string> CollapsedNodesPaths;
	public TArray<string> CollapsedNodesLinks;
	public bool bIsAggregate;
}
