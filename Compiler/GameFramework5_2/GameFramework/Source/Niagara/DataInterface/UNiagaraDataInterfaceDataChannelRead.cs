namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelRead.h")]
public partial class UNiagaraDataInterfaceDataChannelRead : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>When reading from external, the channel to consume.</summary>
	public FNiagaraDataChannelReference Channel;
	///<summary>True if this reader will read the current frame&#39;s data. If false, we read the previous frame.</summary>
	public bool bReadCurrentFrame;
	///<summary>CompiledData</summary>
	public FNDIDataChannelCompiledData CompiledData;
}
