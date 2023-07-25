#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial struct FNiagaraEventHandlerAddAction {
// NiagaraEventHandlerAddAction
	public ENiagaraEventHandlerAddMode Mode;
	public FNiagaraAddEventGeneratorOptions AddEventGeneratorOptions;
	public EScriptExecutionMode ExecutionMode;
	public int SpawnNumber;
	public int MaxEventsPerFrame;
	public FGuid SourceEmitterID;
	public string SourceEventName;
	public bool bRandomSpawnNumber;
	public int MinSpawnNumber;
}
