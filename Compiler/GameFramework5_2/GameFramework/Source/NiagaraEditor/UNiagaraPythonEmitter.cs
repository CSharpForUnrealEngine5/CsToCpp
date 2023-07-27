#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpgradeNiagaraScriptResults.h")]
///<summary>Wrapper for an emitter stack.</summary>
public partial class UNiagaraPythonEmitter : UObject {
// NiagaraPythonEmitter
	public  UNiagaraEmitter GetObject() { return default; }
	public  FVersionedNiagaraEmitterData GetProperties() { return default; }
	public  void SetProperties(FVersionedNiagaraEmitterData Data) {}
	public  TArray<UNiagaraPythonModule> GetModules() { return default; }
	public  bool HasModule(string ModuleName) { return default; }
	public  UNiagaraPythonModule GetModule(string ModuleName) { return default; }
}
