#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action injecting a node into a pin</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMInjectNodeIntoPinAction {
	public string PinPath;
	public bool bAsInput;
	public string InputPinName;
	public string OutputPinName;
	public string NodePath;
}
