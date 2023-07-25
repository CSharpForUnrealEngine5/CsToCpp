#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting the filtered permutations on a template node</summary>
public partial struct FRigVMSetPreferredTemplatePermutationsAction {
// RigVMSetPreferredTemplatePermutationsAction
	public string NodePath;
	public TArray<FRigVMTemplatePreferredType> OldPreferredPermutationTypes;
	public TArray<FRigVMTemplatePreferredType> NewPreferredPermutationTypes;
}
