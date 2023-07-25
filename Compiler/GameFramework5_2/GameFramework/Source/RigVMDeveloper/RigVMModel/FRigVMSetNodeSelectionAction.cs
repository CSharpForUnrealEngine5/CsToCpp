#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action selecting or deselecting a node in the graph.</summary>
public partial struct FRigVMSetNodeSelectionAction {
// RigVMSetNodeSelectionAction
	public TArray<string> NewSelection;
	public TArray<string> OldSelection;
}
