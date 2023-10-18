namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action removing one or more nodes from the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRemoveNodesAction {
	public TArray<FName> NodeNames;
	public string ExportedContent;
}
