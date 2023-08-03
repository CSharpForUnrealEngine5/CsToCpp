#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UOnsetNRT</summary>
[CppInclude("OnsetNRT.h")]
public partial class UOnsetNRT : UAudioSynesthesiaNRT {
	public static UClass StaticClass() {return default;}
	///<summary>The settings for the audio analyzer.</summary>
	public UOnsetNRTSettings Settings;
	///<summary>Returns onsets which occured between start and end timestamps.</summary>
	public  void GetChannelOnsetsBetweenTimes(float InStartSeconds,float InEndSeconds,int InChannel,TArray<float> OutOnsetTimestamps,TArray<float> OutOnsetStrengths) {}
	///<summary>Get a specific channel cqt of the analyzed sound at a given time.</summary>
	public  void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds,float InEndSeconds,int InChannel,TArray<float> OutOnsetTimestamps,TArray<float> OutOnsetStrengths) {}
}
