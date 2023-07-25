#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Helper for reseting/reinitializing Niagara systems currently active when they are being edited.</summary>
public partial struct FNiagaraSystemUpdateContext {
// NiagaraSystemUpdateContext
	public TArray<UNiagaraComponent> ComponentsToReset;
	public TArray<UNiagaraComponent> ComponentsToReInit;
	public TArray<UNiagaraComponent> ComponentsToNotifySimDestroy;
	public TArray<UNiagaraSystem> SystemSimsToDestroy;
	public TArray<UNiagaraSystem> SystemSimsToRecache;
}
