#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class represents a segment of work within the Executor Job. This should be owned</summary>
[CppInclude("MoviePipelineQueue.h")]
public partial class UMoviePipelineExecutorShot : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Set the status of this shot to the given value. This will be shown on the UI if progress</summary>
	public  void SetStatusMessage(string InStatus) {}
	///<summary>Get the current status message for this shot. May be an empty string.</summary>
	public  string GetStatusMessage() { return default; }
	///<summary>Set the progress of this shot to the given value. If a positive value is provided</summary>
	public  void SetStatusProgress(float InProgress) {}
	///<summary>Get the current progress as last set by SetStatusProgress. 0 by default.</summary>
	public  float GetStatusProgress() { return default; }
	///<summary>AllocateNewShotOverrideConfig</summary>
	public  UMoviePipelineShotConfig AllocateNewShotOverrideConfig(UClass InConfigType) { return default; }
	///<summary>SetShotOverrideConfiguration</summary>
	public  void SetShotOverrideConfiguration(UMoviePipelineShotConfig InPreset) {}
	///<summary>SetShotOverridePresetOrigin</summary>
	public  void SetShotOverridePresetOrigin(UMoviePipelineShotConfig InPreset) {}
	///<summary>GetShotOverrideConfiguration</summary>
	public  UMoviePipelineShotConfig GetShotOverrideConfiguration() { return default; }
	///<summary>GetShotOverridePresetOrigin</summary>
	public  UMoviePipelineShotConfig GetShotOverridePresetOrigin() { return default; }
	///<summary>Returns whether this should should be rendered</summary>
	public  bool ShouldRender() { return default; }
	///<summary>GetCameraName</summary>
	public  string GetCameraName(int InCameraIndex) { return default; }
	///<summary>Does the user want to render this shot?</summary>
	public bool bEnabled;
	///<summary>The name of the shot section that contains this shot. Can be empty.</summary>
	public string OuterName;
	///<summary>The name of the camera cut section that this shot represents. Can be empty.</summary>
	public string InnerName;
	///<summary>List of cameras to render for this shot. Only used if the setting flag is set in the Camera setting.</summary>
	public TArray<FMoviePipelineSidecarCamera> SidecarCameras;
	///<summary>Progress</summary>
	public float Progress;
	///<summary>StatusMessage</summary>
	public string StatusMessage;
	///<summary>ShotOverrideConfig</summary>
	public UMoviePipelineShotConfig ShotOverrideConfig;
	///<summary>ShotOverridePresetOrigin</summary>
	public TSoftObjectPtr<UMoviePipelineShotConfig> ShotOverridePresetOrigin;
}
