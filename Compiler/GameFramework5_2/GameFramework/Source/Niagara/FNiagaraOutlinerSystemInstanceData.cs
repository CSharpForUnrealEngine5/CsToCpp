#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Outliner information on a specific system instance.</summary>
public partial struct FNiagaraOutlinerSystemInstanceData {
// NiagaraOutlinerSystemInstanceData
	public string ComponentName;
	public FVector3f LWCTile;
	public TArray<FNiagaraOutlinerEmitterInstanceData> Emitters;
	public ENiagaraExecutionState ActualExecutionState;
	public ENiagaraExecutionState RequestedExecutionState;
	public FNiagaraScalabilityState ScalabilityState;
	public bool bPendingKill;
	public bool bUsingCullProxy;
	public ENCPoolMethod PoolMethod;
	public FNiagaraOutlinerTimingData AverageTime;
	public FNiagaraOutlinerTimingData MaxTime;
	public byte TickGroup;
	public byte GpuTickStage;
	public bool bIsSolo;
	public bool bRequiresDistanceFieldData;
	public bool bRequiresDepthBuffer;
	public bool bRequiresEarlyViewData;
	public bool bRequiresViewUniformBuffer;
	public bool bRequiresRayTracingScene;
}
