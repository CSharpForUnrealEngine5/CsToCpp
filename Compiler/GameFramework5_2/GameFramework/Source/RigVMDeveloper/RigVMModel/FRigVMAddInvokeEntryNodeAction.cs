namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding an invoke entry node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddInvokeEntryNodeAction {
	public string EntryName;
	public FVector2D Position;
	public string NodePath;
}
