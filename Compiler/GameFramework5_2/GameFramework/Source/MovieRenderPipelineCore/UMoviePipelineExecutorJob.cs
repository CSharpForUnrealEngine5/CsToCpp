namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A particular job within the Queue</summary>
[CppInclude("MoviePipelineQueue.h")]
public partial class UMoviePipelineExecutorJob : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Set the status of this job to the given value. This will be shown on the UI if progress</summary>
	public void SetStatusMessage(string InStatus) {}
	///<summary>Get the current status message for this job. May be an empty string.</summary>
	public string GetStatusMessage() { return default; }
	///<summary>Set the progress of this job to the given value. If a positive value is provided</summary>
	public void SetStatusProgress(float InProgress) {}
	///<summary>Get the current progress as last set by SetStatusProgress. 0 by default.</summary>
	public float GetStatusProgress() { return default; }
	///<summary>Set the job to be consumed. A consumed job is disabled in the UI and should not be</summary>
	public void SetConsumed(bool bInConsumed) {}
	///<summary>Gets whether or not the job has been marked as being consumed. A consumed job is not editable</summary>
	public bool IsConsumed() { return default; }
	///<summary>Set the job to be enabled/disabled. This is exposed to the user in the Queue UI</summary>
	public void SetIsEnabled(bool bInEnabled) {}
	///<summary>Gets whether or not the job has been marked as being enabled.</summary>
	public bool IsEnabled() { return default; }
	///<summary>Should be called to clear status and user data after duplication so that jobs stay</summary>
	public void OnDuplicated() {}
	///<summary>SetPresetOrigin</summary>
	public void SetPresetOrigin(UMoviePipelinePrimaryConfig InPreset) {}
	///<summary>Gets the preset for this job, but only if the preset has not been modified. If it has been modified, or the preset</summary>
	public UMoviePipelinePrimaryConfig GetPresetOrigin() { return default; }
	///<summary>Gets the configuration for the job. This configuration is either standalone (not associated with any preset), or</summary>
	public UMoviePipelinePrimaryConfig GetConfiguration() { return default; }
	///<summary>SetConfiguration</summary>
	public void SetConfiguration(UMoviePipelinePrimaryConfig InPreset) {}
	///<summary>SetSequence</summary>
	public void SetSequence(FSoftObjectPath InSequence) {}
	///<summary>(Optional) Name of the job. Shown on the default burn-in.</summary>
	public string JobName;
	///<summary>Which sequence should this job render?</summary>
	public FSoftObjectPath Sequence;
	///<summary>Which map should this job render on</summary>
	public FSoftObjectPath Map;
	///<summary>(Optional) If left blank, will default to system username. Can be shown in burn in as a first point of contact about the content.</summary>
	public string Author;
	///<summary>(Optional) If specified, will be shown in the burn in to allow users to keep track of notes about a render.</summary>
	public string Comment;
	///<summary>(Optional) Shot specific information. If a shot is missing from this list it will assume to be enabled and will be rendered.</summary>
	public TArray<UMoviePipelineExecutorShot> ShotInfo;
	///<summary>Arbitrary data that can be associated with the job. Not used by default implementations, nor read.</summary>
	public string UserData;
	///<summary>StatusMessage</summary>
	public string StatusMessage;
	///<summary>StatusProgress</summary>
	public float StatusProgress;
	///<summary>bIsConsumed</summary>
	public bool bIsConsumed;
	///<summary>Configuration</summary>
	public UMoviePipelinePrimaryConfig Configuration;
	///<summary>PresetOrigin</summary>
	public TSoftObjectPtr<UMoviePipelinePrimaryConfig> PresetOrigin;
	///<summary>Whether this job is enabled and should be rendered.</summary>
	public bool bEnabled;
}
