#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceSimpleCounter.h")]
///<summary>Thread safe counter starts at the initial value on start / reset.</summary>
public partial class UNiagaraDataInterfaceSimpleCounter : UNiagaraDataInterface {
// NiagaraDataInterfaceSimpleCounter
	public ENiagaraGpuSyncMode GpuSyncMode;
	public int InitialValue;
}
