namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a node&#39;s category in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodeCategoryAction {
	public string NodePath;
	public string OldCategory;
	public string NewCategory;
}
