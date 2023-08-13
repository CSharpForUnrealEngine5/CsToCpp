namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class for all Movie Render Pipeline settings.</summary>
[CppInclude("MoviePipelineSetting.h")]
public partial class UMoviePipelineSetting : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>BuildNewProcessCommandLine</summary>
	public void BuildNewProcessCommandLine(string InOutUnrealURLParams,string InOutCommandLineArgs) {}
	///<summary>BuildNewProcessCommandLineArgs</summary>
	public void BuildNewProcessCommandLineArgs(TArray<string> InOutUnrealURLParams,TArray<string> InOutCommandLineArgs,TArray<string> InOutDeviceProfileCvars,TArray<string> InOutExecCmds) {}
	///<summary>Is this setting enabled by the user in the UI?</summary>
	public virtual bool IsEnabled() { return default; }
	///<summary>SetIsEnabled</summary>
	public virtual void SetIsEnabled(bool bInEnabled) {}
	///<summary>CachedPipeline</summary>
	public TWeakObjectPtr<UMoviePipeline> CachedPipeline;
	///<summary>Is this setting currently enabled? Disabled settings are like they never existed.</summary>
	public bool bEnabled;
}
