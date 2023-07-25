#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Audio/Encoders/SimpleAudioEncoder.h")]
public partial class USimpleAudioEncoder : UObject {
// SimpleAudioEncoder
	public bool IsAsync() { return default; }
	public bool IsOpen() { return default; }
	public bool Open(ESimpleAudioCodec Codec,FSimpleAudioEncoderConfig Config,bool bAsynchronous) { return default; }
	public void Close() {}
	public bool SendFrameFloat(TArray<float> Resource,double Timestamp,int NumSamples,float SampleDuration) { return default; }
	public bool ReceivePacket(FSimpleAudioPacket OutPacket) { return default; }
	public void ReceivePackets(TArray<FSimpleAudioPacket> OutPackets) {}
	public ESimpleAudioCodec GetCodec() { return default; }
	public FSimpleAudioEncoderConfig GetConfig() { return default; }
	public void SetConfig(FSimpleAudioEncoderConfig NewConfig) {}
}
