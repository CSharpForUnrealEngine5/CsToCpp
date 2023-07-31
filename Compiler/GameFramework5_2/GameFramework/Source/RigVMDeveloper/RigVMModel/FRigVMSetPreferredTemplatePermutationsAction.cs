#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting the filtered permutations on a template node</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetPreferredTemplatePermutationsAction {
	public string NodePath;
	public TArray<FRigVMTemplatePreferredType> OldPreferredPermutationTypes;
	public TArray<FRigVMTemplatePreferredType> NewPreferredPermutationTypes;
}
