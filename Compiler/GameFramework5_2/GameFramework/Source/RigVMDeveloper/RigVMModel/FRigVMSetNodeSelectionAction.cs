#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action selecting or deselecting a node in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodeSelectionAction {
	public TArray<string> NewSelection;
	public TArray<string> OldSelection;
}
