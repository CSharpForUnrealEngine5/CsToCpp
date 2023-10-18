namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action injecting a node into a pin</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMInjectNodeIntoPinAction {
	public string PinPath;
	public bool bAsInput;
	public FName InputPinName;
	public FName OutputPinName;
	public string NodePath;
}
