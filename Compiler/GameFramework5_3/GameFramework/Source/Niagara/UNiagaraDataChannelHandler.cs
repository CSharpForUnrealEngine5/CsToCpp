namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelHandler.h")]
public partial class UNiagaraDataChannelHandler : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetDataChannelWriter</summary>
	public UNiagaraDataChannelWriter GetDataChannelWriter() { return default; }
	///<summary>GetDataChannelReader</summary>
	public UNiagaraDataChannelReader GetDataChannelReader() { return default; }
	///<summary>DataChannel</summary>
	public TWeakObjectPtr<UNiagaraDataChannel> DataChannel;
	///<summary>Helper object allowing BP to write data in this channel.</summary>
	public UNiagaraDataChannelWriter Writer;
	///<summary>Helper object allowing BP to read data in this channel.</summary>
	public UNiagaraDataChannelReader Reader;
}
