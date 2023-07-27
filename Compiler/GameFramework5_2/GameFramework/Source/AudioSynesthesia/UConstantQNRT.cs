#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstantQNRT.h")]
///<summary>UConstantQNRT</summary>
public partial class UConstantQNRT : UAudioSynesthesiaNRT {
// ConstantQNRT
	public UConstantQNRTSettings Settings;
	public  void GetChannelConstantQAtTime(float InSeconds,int InChannel,TArray<float> OutConstantQ) {}
	public  void GetNormalizedChannelConstantQAtTime(float InSeconds,int InChannel,TArray<float> OutConstantQ) {}
}
