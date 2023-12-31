namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action exposing a pin as a parameter</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRemoveExposedPinAction {
	public string PinName;
	public ERigVMPinDirection Direction;
	public string CPPType;
	public string CPPTypeObjectPath;
	public string DefaultValue;
	public int PinIndex;
}
