namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial struct FNiagaraEventHandlerAddAction {
	public ENiagaraEventHandlerAddMode Mode;
	public FNiagaraAddEventGeneratorOptions AddEventGeneratorOptions;
	public EScriptExecutionMode ExecutionMode;
	public int SpawnNumber;
	public int MaxEventsPerFrame;
	public FGuid SourceEmitterID;
	public FName SourceEventName;
	public bool bRandomSpawnNumber;
	public int MinSpawnNumber;
}
