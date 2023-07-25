#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeUsageSelector.h")]
public partial class UNiagaraNodeUsageSelector : UNiagaraNodeWithDynamicPins {
// NiagaraNodeUsageSelector
	public TArray<FNiagaraVariable> OutputVars;
	public TArray<FGuid> OutputVarGuids;
	public FGuid SelectorGuid;
	public int NumOptionsPerVariable;
}
