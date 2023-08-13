namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to reorder pins on a node</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetPinIndexAction {
	public string PinPath;
	public int OldIndex;
	public int NewIndex;
}
