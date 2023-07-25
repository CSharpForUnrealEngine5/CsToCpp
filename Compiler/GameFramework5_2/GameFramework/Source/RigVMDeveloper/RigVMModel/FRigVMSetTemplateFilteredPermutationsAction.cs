#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting the filtered permutations on a template node</summary>
public partial struct FRigVMSetTemplateFilteredPermutationsAction {
// RigVMSetTemplateFilteredPermutationsAction
	public string NodePath;
	public TArray<int> OldFilteredPermutations;
	public TArray<int> NewFilteredPermutations;
}
