#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper for array of system instance outliner data so that it can be placed in a map.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraOutlinerSystemData {
	public TArray<FNiagaraOutlinerSystemInstanceData> SystemInstances;
	public FNiagaraOutlinerTimingData AveragePerFrameTime;
	public FNiagaraOutlinerTimingData MaxPerFrameTime;
	public FNiagaraOutlinerTimingData AveragePerInstanceTime;
	public FNiagaraOutlinerTimingData MaxPerInstanceTime;
}
