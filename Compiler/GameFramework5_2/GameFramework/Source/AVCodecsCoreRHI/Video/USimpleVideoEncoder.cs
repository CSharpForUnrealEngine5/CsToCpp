#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Video/Encoders/SimpleVideoEncoder.h")]
public partial class USimpleVideoEncoder : UObject {
	///<summary>IsAsync</summary>
	public  bool IsAsync() { return default; }
	///<summary>IsOpen</summary>
	public  bool IsOpen() { return default; }
	///<summary>Open</summary>
	public  bool Open(ESimpleVideoCodec Codec,FSimpleVideoEncoderConfig Config,bool bAsynchronous) { return default; }
	///<summary>Close</summary>
	public  void Close() {}
	///<summary>SendFrameRenderTarget</summary>
	public  bool SendFrameRenderTarget(UTextureRenderTarget2D Resource,double Timestamp,bool bForceKeyframe/*=false*/) { return default; }
	///<summary>SendFrameTexture</summary>
	public  bool SendFrameTexture(UTexture2D Resource,double Timestamp,bool bForceKeyframe/*=false*/) { return default; }
	///<summary>ReceivePacket</summary>
	public  bool ReceivePacket(FSimpleVideoPacket OutPacket) { return default; }
	///<summary>ReceivePackets</summary>
	public  void ReceivePackets(TArray<FSimpleVideoPacket> OutPackets) {}
	///<summary>GetCodec</summary>
	public  ESimpleVideoCodec GetCodec() { return default; }
	///<summary>GetConfig</summary>
	public  FSimpleVideoEncoderConfig GetConfig() { return default; }
	///<summary>SetConfig</summary>
	public  void SetConfig(FSimpleVideoEncoderConfig NewConfig) {}
}
