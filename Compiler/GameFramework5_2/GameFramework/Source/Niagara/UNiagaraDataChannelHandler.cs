#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelHandler.h")]
public partial class UNiagaraDataChannelHandler : UObject {
// NiagaraDataChannelHandler
	public UObject GetDataChannelWriter() { return default; }
	public UObject GetDataChannelReader() { return default; }
	public UNiagaraDataChannel DataChannel;
	public UNiagaraDataChannelWriter Writer;
	public UNiagaraDataChannelReader Reader;
}
