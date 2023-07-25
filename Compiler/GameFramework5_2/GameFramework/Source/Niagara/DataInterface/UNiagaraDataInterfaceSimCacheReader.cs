#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceSimCacheReader.h")]
///<summary>Data interface to read properties from a Niagara Simulation Cache</summary>
public partial class UNiagaraDataInterfaceSimCacheReader : UNiagaraDataInterface {
// NiagaraDataInterfaceSimCacheReader
	public FNiagaraUserParameterBinding SimCacheBinding;
	public UNiagaraSimCache SimCache;
	public string EmitterBinding;
}
