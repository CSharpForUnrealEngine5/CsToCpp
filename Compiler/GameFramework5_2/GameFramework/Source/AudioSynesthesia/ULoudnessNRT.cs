#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULoudnessNRT</summary>
[CppInclude("LoudnessNRT.h")]
public partial class ULoudnessNRT : UAudioSynesthesiaNRT {
	public static UClass StaticClass() {return default;}
	///<summary>The settings for the audio analyzer.</summary>
	public ULoudnessNRTSettings Settings;
	///<summary>Get the overall loudness of the analyzed sound at a given time.</summary>
	public  void GetLoudnessAtTime(float InSeconds,float OutLoudness) {}
	///<summary>Get a specific channel loudness of the analyzed sound at a given time.</summary>
	public  void GetChannelLoudnessAtTime(float InSeconds,int InChannel,float OutLoudness) {}
	///<summary>Get the normalized overall loudness of the analyzed sound at a given time. Normalized loudness</summary>
	public  void GetNormalizedLoudnessAtTime(float InSeconds,float OutLoudness) {}
	///<summary>Get a specific channel normalized loudness of the analyzed sound at a given time. Normalized</summary>
	public  void GetNormalizedChannelLoudnessAtTime(float InSeconds,int InChannel,float OutLoudness) {}
}
