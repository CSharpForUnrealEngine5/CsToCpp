namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper for reseting/reinitializing Niagara systems currently active when they are being edited.</summary>
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraSystemUpdateContext {
	public TArray<UNiagaraComponent> ComponentsToReset;
	public TArray<UNiagaraComponent> ComponentsToReInit;
	public TArray<UNiagaraComponent> ComponentsToNotifySimDestroy;
	public TArray<UNiagaraSystem> SystemSimsToDestroy;
	public TArray<UNiagaraSystem> SystemSimsToRecache;
}
