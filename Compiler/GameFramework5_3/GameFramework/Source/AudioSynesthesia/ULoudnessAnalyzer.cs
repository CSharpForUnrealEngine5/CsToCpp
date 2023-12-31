namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULoudnessAnalyzer</summary>
[CppInclude("Loudness.h")]
public partial class ULoudnessAnalyzer : UAudioAnalyzer {
	public static UClass StaticClass() {return default;}
	///<summary>The settings for the audio analyzer.</summary>
	public ULoudnessSettings Settings;
	///<summary>Delegate to receive all overall loudness results since last delegate call.</summary>
	public FOnOverallLoudnessResults OnOverallLoudnessResults;
	///<summary>Delegate to receive all loudness results, per-channel, since last delegate call.</summary>
	public FOnPerChannelLoudnessResults OnPerChannelLoudnessResults;
	///<summary>Delegate to receive the latest overall loudness results.</summary>
	public FOnLatestOverallLoudnessResults OnLatestOverallLoudnessResults;
	///<summary>Delegate to receive the latest per-channel loudness results.</summary>
	public FOnLatestPerChannelLoudnessResults OnLatestPerChannelLoudnessResults;
}
