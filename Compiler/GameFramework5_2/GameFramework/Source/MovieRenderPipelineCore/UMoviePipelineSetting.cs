#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineSetting.h")]
///<summary>A base class for all Movie Render Pipeline settings.</summary>
public partial class UMoviePipelineSetting : UObject {
// MoviePipelineSetting
	public void BuildNewProcessCommandLine(string InOutUnrealURLParams,string InOutCommandLineArgs) {}
	public void BuildNewProcessCommandLineArgs(TArray<string> InOutUnrealURLParams,TArray<string> InOutCommandLineArgs,TArray<string> InOutDeviceProfileCvars,TArray<string> InOutExecCmds) {}
	public bool IsEnabled() { return default; }
	public void SetIsEnabled(bool bInEnabled) {}
	public TWeakObjectPtr<UMoviePipeline> CachedPipeline;
	public bool bEnabled;
}
