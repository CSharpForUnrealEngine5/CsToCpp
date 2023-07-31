#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Audio/Encoders/SimpleAudioEncoder.h")]
public partial class USimpleAudioEncoder : UObject {
	///<summary>IsAsync</summary>
	public  bool IsAsync() { return default; }
	///<summary>IsOpen</summary>
	public  bool IsOpen() { return default; }
	///<summary>Open</summary>
	public  bool Open(ESimpleAudioCodec Codec,FSimpleAudioEncoderConfig Config,bool bAsynchronous) { return default; }
	///<summary>Close</summary>
	public  void Close() {}
	///<summary>SendFrameFloat</summary>
	public  bool SendFrameFloat(TArray<float> Resource,double Timestamp,int NumSamples,float SampleDuration) { return default; }
	///<summary>ReceivePacket</summary>
	public  bool ReceivePacket(FSimpleAudioPacket OutPacket) { return default; }
	///<summary>ReceivePackets</summary>
	public  void ReceivePackets(TArray<FSimpleAudioPacket> OutPackets) {}
	///<summary>GetCodec</summary>
	public  ESimpleAudioCodec GetCodec() { return default; }
	///<summary>GetConfig</summary>
	public  FSimpleAudioEncoderConfig GetConfig() { return default; }
	///<summary>SetConfig</summary>
	public  void SetConfig(FSimpleAudioEncoderConfig NewConfig) {}
}
