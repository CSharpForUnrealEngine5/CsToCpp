namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a pin&#39;s watch state in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetPinWatchAction {
	public string PinPath;
	public bool OldIsWatched;
	public bool NewIsWatched;
}
