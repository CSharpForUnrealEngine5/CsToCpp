namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action selecting or deselecting a node in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodeSelectionAction {
	public TArray<FName> NewSelection;
	public TArray<FName> OldSelection;
}
