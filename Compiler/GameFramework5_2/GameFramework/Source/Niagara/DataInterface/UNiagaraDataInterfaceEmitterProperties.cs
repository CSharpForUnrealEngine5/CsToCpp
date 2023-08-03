#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows access to various emitter properties that are not part of the simulation data.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceEmitterProperties.h")]
public partial class UNiagaraDataInterfaceEmitterProperties : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Selects which emitter the data interface will bind to, i.e the emitter we are contained within or a named emitter.</summary>
	public FNiagaraDataInterfaceEmitterBinding EmitterBinding;
}
