#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to promote a function to collapse node or vice versa</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMPromoteNodeAction {
	public string LibraryNodePath;
	public string FunctionDefinitionPath;
	public bool bFromFunctionToCollapseNode;
}
