#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Video/Decoders/SimpleVideoDecoder.h")]
public partial class USimpleVideoDecoder : UObject {
// SimpleVideoDecoder
	public  bool IsAsync() { return default; }
	public  bool IsOpen() { return default; }
	public  bool Open(ESimpleVideoCodec Codec,bool bAsynchronous) { return default; }
	public  void Close() {}
	public  bool SendPacket(FSimpleVideoPacket Packet) { return default; }
	public  bool ReceiveFrame(UTextureRenderTarget2D Resource) { return default; }
	public  ESimpleVideoCodec GetCodec() { return default; }
}
