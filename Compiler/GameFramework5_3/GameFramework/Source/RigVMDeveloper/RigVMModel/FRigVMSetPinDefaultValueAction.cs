namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a pin&#39;s default value in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetPinDefaultValueAction {
	public string PinPath;
	public string OldDefaultValue;
	public string NewDefaultValue;
}
