namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class describes the main configuration for a Movie Render Pipeline.</summary>
[CppInclude("MoviePipelinePrimaryConfig.h")]
public partial class UMoviePipelinePrimaryConfig : UMoviePipelineConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes a single instance of every setting so that even non-user-configured settings have a chance to apply their default values. Does nothing if they&#39;re already instanced for this configuration.</summary>
	public void InitializeTransientSettings() {}
	///<summary>GetTransientSettings</summary>
	public TArray<UMoviePipelineSetting> GetTransientSettings() { return default; }
	///<summary>GetAllSettings</summary>
	public TArray<UMoviePipelineSetting> GetAllSettings(bool bIncludeDisabledSettings/*=false*/,bool bIncludeTransientSettings/*=false*/) { return default; }
	///<summary>Returns the frame rate override from the Primary Configuration (if any) or the Sequence frame rate if no override is specified.</summary>
	public FFrameRate GetEffectiveFrameRate(ULevelSequence InSequence) { return default; }
	///<summary>A mapping of Shot Name -&gt; Shot Config to use for rendering specific shots with specific configs.</summary>
	public TMap<string,UMoviePipelineShotConfig> PerShotConfigMapping;
	///<summary>OutputSetting</summary>
	public UMoviePipelineOutputSetting OutputSetting;
	///<summary>An array of settings that are available in the engine and have not been edited by the user.</summary>
	public TArray<UMoviePipelineSetting> TransientSettings;
}
