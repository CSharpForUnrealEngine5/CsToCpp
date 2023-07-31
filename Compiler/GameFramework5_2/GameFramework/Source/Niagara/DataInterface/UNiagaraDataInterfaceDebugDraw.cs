#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDebugDraw.h")]
public partial class UNiagaraDataInterfaceDebugDraw : UNiagaraDataInterface {
	///<summary>Number of debug lines is set as the max of OverrideMaxLineInstances and fx.Niagara.GpuComputeDebug.MaxLineInstances</summary>
	public uint OverrideMaxLineInstances;
}
