#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnsetNRT.h")]
///<summary>UOnsetNRT</summary>
public partial class UOnsetNRT : UAudioSynesthesiaNRT {
// OnsetNRT
	public UOnsetNRTSettings Settings;
	public void GetChannelOnsetsBetweenTimes(float InStartSeconds,float InEndSeconds,int InChannel,TArray<float> OutOnsetTimestamps,TArray<float> OutOnsetStrengths) {}
	public void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds,float InEndSeconds,int InChannel,TArray<float> OutOnsetTimestamps,TArray<float> OutOnsetStrengths) {}
}
