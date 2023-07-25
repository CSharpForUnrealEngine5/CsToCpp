#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action injecting a node into a pin</summary>
public partial struct FRigVMInjectNodeIntoPinAction {
// RigVMInjectNodeIntoPinAction
	public string PinPath;
	public bool bAsInput;
	public string InputPinName;
	public string OutputPinName;
	public string NodePath;
}
