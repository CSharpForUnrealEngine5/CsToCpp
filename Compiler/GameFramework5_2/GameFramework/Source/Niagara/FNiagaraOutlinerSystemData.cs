#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Wrapper for array of system instance outliner data so that it can be placed in a map.</summary>
public partial struct FNiagaraOutlinerSystemData {
// NiagaraOutlinerSystemData
	public TArray<FNiagaraOutlinerSystemInstanceData> SystemInstances;
	public FNiagaraOutlinerTimingData AveragePerFrameTime;
	public FNiagaraOutlinerTimingData MaxPerFrameTime;
	public FNiagaraOutlinerTimingData AveragePerInstanceTime;
	public FNiagaraOutlinerTimingData MaxPerInstanceTime;
}
