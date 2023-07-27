#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Video/Encoders/SimpleVideoEncoder.h")]
public partial class USimpleVideoEncoder : UObject {
// SimpleVideoEncoder
	public  bool IsAsync() { return default; }
	public  bool IsOpen() { return default; }
	public  bool Open(ESimpleVideoCodec Codec,FSimpleVideoEncoderConfig Config,bool bAsynchronous) { return default; }
	public  void Close() {}
	public  bool SendFrameRenderTarget(UTextureRenderTarget2D Resource,double Timestamp,bool bForceKeyframe/*=false*/) { return default; }
	public  bool SendFrameTexture(UTexture2D Resource,double Timestamp,bool bForceKeyframe/*=false*/) { return default; }
	public  bool ReceivePacket(FSimpleVideoPacket OutPacket) { return default; }
	public  void ReceivePackets(TArray<FSimpleVideoPacket> OutPackets) {}
	public  ESimpleVideoCodec GetCodec() { return default; }
	public  FSimpleVideoEncoderConfig GetConfig() { return default; }
	public  void SetConfig(FSimpleVideoEncoderConfig NewConfig) {}
}
