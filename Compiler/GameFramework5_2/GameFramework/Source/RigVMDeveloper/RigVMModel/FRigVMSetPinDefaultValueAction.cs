#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a pin's default value in the graph.</summary>
public partial struct FRigVMSetPinDefaultValueAction {
// RigVMSetPinDefaultValueAction
	public string PinPath;
	public string OldDefaultValue;
	public string NewDefaultValue;
}
