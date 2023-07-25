#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Loudness.h")]
///<summary>ULoudnessAnalyzer</summary>
public partial class ULoudnessAnalyzer : UAudioAnalyzer {
// LoudnessAnalyzer
	public ULoudnessSettings Settings;
	public FOnOverallLoudnessResults OnOverallLoudnessResults;
	public FOnPerChannelLoudnessResults OnPerChannelLoudnessResults;
	public FOnLatestOverallLoudnessResults OnLatestOverallLoudnessResults;
	public FOnLatestPerChannelLoudnessResults OnLatestPerChannelLoudnessResults;
}
