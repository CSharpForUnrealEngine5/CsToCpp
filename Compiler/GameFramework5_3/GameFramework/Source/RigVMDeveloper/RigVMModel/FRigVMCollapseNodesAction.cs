namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to collapse a selection of nodes</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMCollapseNodesAction {
	public string LibraryNodePath;
	public string CollapsedNodesContent;
	public TArray<string> CollapsedNodesPaths;
	public bool bIsAggregate;
}
