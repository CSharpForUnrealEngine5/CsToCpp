namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a pin&#39;s expansion state in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetPinExpansionAction {
	public string PinPath;
	public bool OldIsExpanded;
	public bool NewIsExpanded;
}
