#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to reorder pins on a node</summary>
public partial struct FRigVMSetPinIndexAction {
// RigVMSetPinIndexAction
	public string PinPath;
	public int OldIndex;
	public int NewIndex;
}
