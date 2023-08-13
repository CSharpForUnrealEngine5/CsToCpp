namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding a new link to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddLinkAction {
	public string OutputPinPath;
	public string InputPinPath;
}
