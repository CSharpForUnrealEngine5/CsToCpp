#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Records necessary information to verify that this will link properly and trace where that linkage dependency exists.</summary>
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraCompileDependency {
	public string LinkerErrorMessage;
	public FGuid NodeGuid;
	public FGuid PinGuid;
	public TArray<FGuid> StackGuids;
	public FNiagaraVariableBase DependentVariable;
	public bool bDependentVariableFromCustomIterationNamespace;
}
