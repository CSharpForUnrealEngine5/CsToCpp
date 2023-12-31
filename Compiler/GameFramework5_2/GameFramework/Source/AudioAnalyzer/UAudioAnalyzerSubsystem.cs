namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class manages querying analysis results from various audio analyzers.</summary>
[CppInclude("AudioAnalyzerSubsystem.h")]
public partial class UAudioAnalyzerSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>AudioAnalyzers</summary>
	public TArray<UAudioAnalyzer> AudioAnalyzers;
}
