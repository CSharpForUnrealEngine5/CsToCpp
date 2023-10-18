namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a node&#39;s size in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodeSizeAction {
	public string NodePath;
	public FVector2D OldSize;
	public FVector2D NewSize;
}
