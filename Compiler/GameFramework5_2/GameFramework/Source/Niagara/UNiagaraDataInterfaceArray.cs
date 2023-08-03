#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceArray.h")]
public partial class UNiagaraDataInterfaceArray : UNiagaraDataInterfaceRWBase {
	public static UClass StaticClass() {return default;}
	///<summary>How to do we want to synchronize modifications to the array data.</summary>
	public ENiagaraGpuSyncMode GpuSyncMode;
	///<summary>When greater than 0 sets the maximum number of elements the array can hold, only relevant when using operations that modify the array size.</summary>
	public int MaxElements;
}
