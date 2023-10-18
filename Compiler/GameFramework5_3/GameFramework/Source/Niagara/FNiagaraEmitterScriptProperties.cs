namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitter.h")]
public partial struct FNiagaraEmitterScriptProperties {
	public UNiagaraScript Script;
	public TArray<FNiagaraEventReceiverProperties> EventReceivers;
	public TArray<FNiagaraEventGeneratorProperties> EventGenerators;
}
