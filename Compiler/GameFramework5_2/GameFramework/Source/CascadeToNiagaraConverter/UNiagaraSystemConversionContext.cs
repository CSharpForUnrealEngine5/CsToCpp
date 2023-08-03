#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper for modifying a UNiagaraSystem by adding Emitters through UNiagaraEmitterConversionContexts.</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial class UNiagaraSystemConversionContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Cleanup</summary>
	public  void Cleanup() {}
	///<summary>Add an empty emitter to the system and return an emitter conversion context.</summary>
	public  UNiagaraEmitterConversionContext AddEmptyEmitter(string NewEmitterNameString) { return default; }
	///<summary>Apply all pending UNiagaraScriptConversionContexts and UNiagaraRendererProperties to the owned</summary>
	public  void Finalize() {}
}
