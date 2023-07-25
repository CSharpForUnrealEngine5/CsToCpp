#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitter.h")]
public partial struct FNiagaraEmitterScriptProperties {
// NiagaraEmitterScriptProperties
	public UNiagaraScript Script;
	public TArray<FNiagaraEventReceiverProperties> EventReceivers;
	public TArray<FNiagaraEventGeneratorProperties> EventGenerators;
}
