namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action changing a pin type</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMChangePinTypeAction {
	public string PinPath;
	public int OldTypeIndex;
	public int NewTypeIndex;
	public bool bSetupOrphanPins;
	public bool bBreakLinks;
	public bool bRemoveSubPins;
}
