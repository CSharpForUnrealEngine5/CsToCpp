namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class represents a segment of work within the Executor Job. This should be owned</summary>
[CppInclude("MoviePipelineQueue.h")]
public partial class UMoviePipelineExecutorShot : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Set the status of this shot to the given value. This will be shown on the UI if progress</summary>
	public void SetStatusMessage(string InStatus) {}
	///<summary>Get the current status message for this shot. May be an empty string.</summary>
	public string GetStatusMessage() { return default; }
	///<summary>Set the progress of this shot to the given value. If a positive value is provided</summary>
	public void SetStatusProgress(float InProgress) {}
	///<summary>Get the current progress as last set by SetStatusProgress. 0 by default.</summary>
	public float GetStatusProgress() { return default; }
	///<summary>AllocateNewShotOverrideConfig</summary>
	public UMoviePipelineShotConfig AllocateNewShotOverrideConfig(UClass InConfigType) { return default; }
	///<summary>SetShotOverrideConfiguration</summary>
	public void SetShotOverrideConfiguration(UMoviePipelineShotConfig InPreset) {}
	///<summary>SetShotOverridePresetOrigin</summary>
	public void SetShotOverridePresetOrigin(UMoviePipelineShotConfig InPreset) {}
	///<summary>GetShotOverrideConfiguration</summary>
	public UMoviePipelineShotConfig GetShotOverrideConfiguration() { return default; }
	///<summary>GetShotOverridePresetOrigin</summary>
	public UMoviePipelineShotConfig GetShotOverridePresetOrigin() { return default; }
	///<summary>Returns true if this job is using graph-style configuration, else false.</summary>
	public bool IsUsingGraphConfiguration() { return default; }
	///<summary>Gets the graph-style preset that this job is using. If the job is not using a graph-style preset, returns nullptr.</summary>
	public UMovieGraphConfig GetGraphPreset() { return default; }
	///<summary>Gets the graph-style config that this job is using. If the job is not using a graph-style config, returns nullptr.</summary>
	public UMovieGraphConfig GetGraphConfig() { return default; }
	///<summary>Sets the graph-style preset that this job will use. Note that this will cause the graph to switch over to using</summary>
	public void SetGraphPreset(UMovieGraphConfig InGraphPreset) {}
	///<summary>Sets the graph-style config that this job will use. Note that this will cause the graph to switch over to using</summary>
	public void SetGraphConfig(UMovieGraphConfig InGraphConfig) {}
	///<summary>Returns whether this should should be rendered</summary>
	public bool ShouldRender() { return default; }
	///<summary>GetCameraName</summary>
	public string GetCameraName(int InCameraIndex) { return default; }
	///<summary>Does the user want to render this shot?</summary>
	public bool bEnabled;
	///<summary>The name of the shot section that contains this shot. Can be empty.</summary>
	public string OuterName;
	///<summary>The name of the camera cut section that this shot represents. Can be empty.</summary>
	public string InnerName;
	///<summary>List of cameras to render for this shot. Only used if the setting flag is set in the Camera setting.</summary>
	public TArray<FMoviePipelineSidecarCamera> SidecarCameras;
	///<summary>Overrides on the variables in graph preset associated with this job.</summary>
	public UMovieJobVariableAssignmentContainer VariableAssignments;
	///<summary>Progress</summary>
	public float Progress;
	///<summary>StatusMessage</summary>
	public string StatusMessage;
	///<summary>ShotOverrideConfig</summary>
	public UMoviePipelineShotConfig ShotOverrideConfig;
	///<summary>ShotOverridePresetOrigin</summary>
	public TSoftObjectPtr<UMoviePipelineShotConfig> ShotOverridePresetOrigin;
	///<summary>The graph-based configuration that this shot is using; Can be nullptr.</summary>
	public UMovieGraphConfig GraphConfig;
	///<summary>The graph-based configuration preset that this shot is using. Can be nullptr.</summary>
	public TSoftObjectPtr<UMovieGraphConfig> GraphPreset;
}
