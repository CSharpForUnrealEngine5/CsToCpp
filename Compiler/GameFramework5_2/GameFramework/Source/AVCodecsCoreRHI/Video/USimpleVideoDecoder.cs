#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Video/Decoders/SimpleVideoDecoder.h")]
public partial class USimpleVideoDecoder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>IsAsync</summary>
	public  bool IsAsync() { return default; }
	///<summary>IsOpen</summary>
	public  bool IsOpen() { return default; }
	///<summary>Open</summary>
	public  bool Open(ESimpleVideoCodec Codec,bool bAsynchronous) { return default; }
	///<summary>Close</summary>
	public  void Close() {}
	///<summary>SendPacket</summary>
	public  bool SendPacket(FSimpleVideoPacket Packet) { return default; }
	///<summary>ReceiveFrame</summary>
	public  bool ReceiveFrame(UTextureRenderTarget2D Resource) { return default; }
	///<summary>GetCodec</summary>
	public  ESimpleVideoCodec GetCodec() { return default; }
}
