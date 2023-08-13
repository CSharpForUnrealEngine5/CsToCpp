namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper for an emitter stack.</summary>
[CppInclude("UpgradeNiagaraScriptResults.h")]
public partial class UNiagaraPythonEmitter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the raw underlying object</summary>
	public UNiagaraEmitter GetObject() { return default; }
	///<summary>returns the emitter properties, such as determinism or interpolated spawning</summary>
	public FVersionedNiagaraEmitterData GetProperties() { return default; }
	///<summary>sets the new emitter properties</summary>
	public void SetProperties(FVersionedNiagaraEmitterData Data) {}
	///<summary>returns a list of all modules contained in this emitter</summary>
	public TArray<UNiagaraPythonModule> GetModules() { return default; }
	///<summary>returns true if the emitter contains a certain module</summary>
	public bool HasModule(string ModuleName) { return default; }
	///<summary>returns a module by name</summary>
	public UNiagaraPythonModule GetModule(string ModuleName) { return default; }
}
