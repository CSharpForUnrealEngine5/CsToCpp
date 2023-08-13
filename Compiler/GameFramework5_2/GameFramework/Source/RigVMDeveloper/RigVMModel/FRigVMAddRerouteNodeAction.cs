namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding a reroute node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddRerouteNodeAction {
	public bool bShowAsFullNode;
	public string CPPType;
	public string CPPTypeObjectPath;
	public string DefaultValue;
	public bool bIsConstant;
	public string CustomWidgetName;
	public FVector2D Position;
	public string NodePath;
}
