#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LoudnessNRT.h")]
///<summary>ULoudnessNRT</summary>
public partial class ULoudnessNRT : UAudioSynesthesiaNRT {
// LoudnessNRT
	public ULoudnessNRTSettings Settings;
	public  void GetLoudnessAtTime(float InSeconds,float OutLoudness) {}
	public  void GetChannelLoudnessAtTime(float InSeconds,int InChannel,float OutLoudness) {}
	public  void GetNormalizedLoudnessAtTime(float InSeconds,float OutLoudness) {}
	public  void GetNormalizedChannelLoudnessAtTime(float InSeconds,int InChannel,float OutLoudness) {}
}
