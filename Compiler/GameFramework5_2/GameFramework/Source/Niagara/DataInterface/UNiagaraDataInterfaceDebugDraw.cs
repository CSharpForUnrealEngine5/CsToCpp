namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDebugDraw.h")]
public partial class UNiagaraDataInterfaceDebugDraw : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Number of debug lines is set as the max of OverrideMaxLineInstances and fx.Niagara.GpuComputeDebug.MaxLineInstances</summary>
	public uint OverrideMaxLineInstances;
}
