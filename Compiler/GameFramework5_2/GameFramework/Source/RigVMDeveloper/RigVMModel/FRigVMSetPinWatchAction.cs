#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a pin's watch state in the graph.</summary>
public partial struct FRigVMSetPinWatchAction {
// RigVMSetPinWatchAction
	public string PinPath;
	public bool OldIsWatched;
	public bool NewIsWatched;
}
