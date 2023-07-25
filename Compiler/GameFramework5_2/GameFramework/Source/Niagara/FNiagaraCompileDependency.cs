#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Records necessary information to verify that this will link properly and trace where that linkage dependency exists.</summary>
public partial struct FNiagaraCompileDependency {
// NiagaraCompileDependency
	public string LinkerErrorMessage;
	public FGuid NodeGuid;
	public FGuid PinGuid;
	public TArray<FGuid> StackGuids;
	public FNiagaraVariableBase DependentVariable;
	public bool bDependentVariableFromCustomIterationNamespace;
}
