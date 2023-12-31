namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a node&#39;s position in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodePositionAction {
	public string NodePath;
	public FVector2D OldPosition;
	public FVector2D NewPosition;
}
