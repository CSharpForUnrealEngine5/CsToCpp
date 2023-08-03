#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Thread safe counter starts at the initial value on start / reset.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceSimpleCounter.h")]
public partial class UNiagaraDataInterfaceSimpleCounter : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Select how we should synchronize the counter between Cpu &amp; Gpu</summary>
	public ENiagaraGpuSyncMode GpuSyncMode;
	///<summary>This is the value the counter will have when the instance is reset / created.</summary>
	public int InitialValue;
}
