#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data interface to read properties from a Niagara Simulation Cache</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceSimCacheReader.h")]
public partial class UNiagaraDataInterfaceSimCacheReader : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>User parameter Object binding if this is not a valid sim cache the default one will be used instead.</summary>
	public FNiagaraUserParameterBinding SimCacheBinding;
	///<summary>Optional source SimCache to use, if the user parameter binding is valid this will be ignored.</summary>
	public UNiagaraSimCache SimCache;
	///<summary>Which Emitter we should read from within the SimCache.</summary>
	public string EmitterBinding;
}
