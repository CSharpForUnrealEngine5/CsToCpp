#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UConstantQNRT</summary>
[CppInclude("ConstantQNRT.h")]
public partial class UConstantQNRT : UAudioSynesthesiaNRT {
	public static UClass StaticClass() {return default;}
	///<summary>The settings for the audio analyzer.</summary>
	public UConstantQNRTSettings Settings;
	///<summary>Get a specific channel cqt of the analyzed sound at a given time.</summary>
	public  void GetChannelConstantQAtTime(float InSeconds,int InChannel,TArray<float> OutConstantQ) {}
	///<summary>Get a specific channel cqt of the analyzed sound at a given time.</summary>
	public  void GetNormalizedChannelConstantQAtTime(float InSeconds,int InChannel,TArray<float> OutConstantQ) {}
}
