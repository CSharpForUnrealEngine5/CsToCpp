#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeInput.h")]
public partial class UNiagaraNodeInput : UNiagaraNode {
// NiagaraNodeInput
	public FNiagaraVariable Input;
	public ENiagaraInputNodeUsage Usage;
	public int CallSortPriority;
	public FNiagaraInputExposureOptions ExposureOptions;
	public UNiagaraDataInterface DataInterface;
}
