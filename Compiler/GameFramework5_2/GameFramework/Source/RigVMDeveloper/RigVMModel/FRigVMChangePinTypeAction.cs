#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action changing a pin type</summary>
public partial struct FRigVMChangePinTypeAction {
// RigVMChangePinTypeAction
	public string PinPath;
	public int OldTypeIndex;
	public int NewTypeIndex;
	public bool bSetupOrphanPins;
	public bool bBreakLinks;
	public bool bRemoveSubPins;
}
