namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitter.h")]
public partial struct FNiagaraEventScriptProperties {
	public EScriptExecutionMode ExecutionMode;
	public uint SpawnNumber;
	public uint MaxEventsPerFrame;
	public FGuid SourceEmitterID;
	public FName SourceEventName;
	public bool bRandomSpawnNumber;
	public uint MinSpawnNumber;
	public bool UpdateAttributeInitialValues;
}
