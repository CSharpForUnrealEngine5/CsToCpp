namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action renaming an exposed in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRenameExposedPinAction {
	public string OldPinName;
	public string NewPinName;
}
