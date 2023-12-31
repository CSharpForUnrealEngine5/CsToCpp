namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action renaming a node in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRenameNodeAction {
	public string OldNodeName;
	public string NewNodeName;
}
