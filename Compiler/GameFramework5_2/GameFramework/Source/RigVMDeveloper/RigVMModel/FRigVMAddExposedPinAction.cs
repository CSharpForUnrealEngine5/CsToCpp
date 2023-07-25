#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action exposing a pin as a parameter</summary>
public partial struct FRigVMAddExposedPinAction {
// RigVMAddExposedPinAction
	public string PinName;
	public ERigVMPinDirection Direction;
	public string CPPType;
	public string CPPTypeObjectPath;
	public string DefaultValue;
}
