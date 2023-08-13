namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class represents a render grid job, in other words, an entry (a row) of a render grid.</summary>
[CppInclude("RenderGrid/RenderGrid.h")]
public partial class URenderGridJob : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the resolution that this job will be rendered in.</summary>
	public FIntPoint GetOutputResolution() { return default; }
	///<summary>Gets the aspect ratio that this job will be rendered in.</summary>
	public double GetOutputAspectRatio() { return default; }
	///<summary>Checks whether the job contains data that matches the search terms.</summary>
	public bool MatchesSearchTerm(string SearchTerm) { return default; }
	///<summary>Returns the GUID, which is randomly generated at creation.</summary>
	public FGuid GetGuid() { return default; }
	///<summary>Randomly generates a new GUID.</summary>
	public void GenerateNewGuid() {}
	///<summary>GetWaitFramesBeforeRendering</summary>
	public int GetWaitFramesBeforeRendering() { return default; }
	///<summary>SetWaitFramesBeforeRendering</summary>
	public void SetWaitFramesBeforeRendering(int NewWaitFramesBeforeRendering) {}
	///<summary>GetLevelSequence</summary>
	public ULevelSequence GetLevelSequence() { return default; }
	///<summary>SetLevelSequence</summary>
	public void SetLevelSequence(ULevelSequence NewSequence) {}
	///<summary>GetIsUsingCustomStartFrame</summary>
	public bool GetIsUsingCustomStartFrame() { return default; }
	///<summary>SetIsUsingCustomStartFrame</summary>
	public void SetIsUsingCustomStartFrame(bool bNewOverrideStartFrame) {}
	///<summary>GetCustomStartFrame</summary>
	public int GetCustomStartFrame() { return default; }
	///<summary>SetCustomStartFrame</summary>
	public void SetCustomStartFrame(int NewCustomStartFrame) {}
	///<summary>GetIsUsingCustomEndFrame</summary>
	public bool GetIsUsingCustomEndFrame() { return default; }
	///<summary>SetIsUsingCustomEndFrame</summary>
	public void SetIsUsingCustomEndFrame(bool bNewOverrideEndFrame) {}
	///<summary>GetCustomEndFrame</summary>
	public int GetCustomEndFrame() { return default; }
	///<summary>SetCustomEndFrame</summary>
	public void SetCustomEndFrame(int NewCustomEndFrame) {}
	///<summary>GetIsUsingCustomResolution</summary>
	public bool GetIsUsingCustomResolution() { return default; }
	///<summary>SetIsUsingCustomResolution</summary>
	public void SetIsUsingCustomResolution(bool bNewOverrideResolution) {}
	///<summary>GetCustomResolution</summary>
	public FIntPoint GetCustomResolution() { return default; }
	///<summary>SetCustomResolution</summary>
	public void SetCustomResolution(FIntPoint NewCustomResolution) {}
	///<summary>GetJobId</summary>
	public string GetJobId() { return default; }
	///<summary>SetJobId</summary>
	public void SetJobId(string NewJobId) {}
	///<summary>GetJobName</summary>
	public string GetJobName() { return default; }
	///<summary>SetJobName</summary>
	public void SetJobName(string NewJobName) {}
	///<summary>GetIsEnabled</summary>
	public bool GetIsEnabled() { return default; }
	///<summary>SetIsEnabled</summary>
	public void SetIsEnabled(bool bEnabled) {}
	///<summary>GetOutputDirectory</summary>
	public string GetOutputDirectory() { return default; }
	///<summary>GetOutputDirectoryForDisplay</summary>
	public string GetOutputDirectoryForDisplay() { return default; }
	///<summary>SetOutputDirectory</summary>
	public void SetOutputDirectory(string NewOutputDirectory) {}
	///<summary>GetRenderPreset</summary>
	public UMoviePipelinePrimaryConfig GetRenderPreset() { return default; }
	///<summary>GetRenderPresetOutputSettings</summary>
	public UMoviePipelineOutputSetting GetRenderPresetOutputSettings() { return default; }
	///<summary>SetRenderPreset</summary>
	public void SetRenderPreset(UMoviePipelinePrimaryConfig NewRenderPreset) {}
	///<summary>HasRemoteControlValue</summary>
	public bool HasRemoteControlValue(FGuid FieldId) { return default; }
	///<summary>GetRemoteControlValue</summary>
	public bool GetRemoteControlValue(FGuid FieldId,string OutJson) { return default; }
	///<summary>SetRemoteControlValue</summary>
	public bool SetRemoteControlValue(FGuid FieldId,string Json) { return default; }
	///<summary>GetRemoteControlFieldIdFromLabel</summary>
	public bool GetRemoteControlFieldIdFromLabel(string Label,FGuid OutFieldId) { return default; }
	///<summary>GetRemoteControlLabelFromFieldId</summary>
	public bool GetRemoteControlLabelFromFieldId(FGuid FieldId,string OutLabel) { return default; }
	///<summary>GetRemoteControlValues</summary>
	public TMap<FGuid,string> GetRemoteControlValues() { return default; }
	///<summary>The unique ID of this job.</summary>
	public FGuid Guid;
	///<summary>Waits the given number of frames before it will render this job. This can be set to a higher amount when the renderer has to wait for your code to complete (such as construction scripts etc). Try increasing this value when rendering doesn&#39;t produce the output you expect it to.</summary>
	public int WaitFramesBeforeRendering;
	///<summary>The level sequence, this is what will be rendered during rendering. A job without a level sequence can&#39;t be rendered.</summary>
	public ULevelSequence LevelSequence;
	///<summary>If this is true, the CustomStartFrame property will override the start frame of the level sequence.</summary>
	public bool bOverrideStartFrame;
	///<summary>If bOverrideStartFrame is true, this property will override the start frame of the level sequence.</summary>
	public int CustomStartFrame;
	///<summary>If this is true, the CustomEndFrame property will override the end frame of the level sequence.</summary>
	public bool bOverrideEndFrame;
	///<summary>If bOverrideEndFrame is true, this property will override the end frame of the level sequence.</summary>
	public int CustomEndFrame;
	///<summary>If this is true, the CustomResolution property will override the resolution of the render.</summary>
	public bool bOverrideResolution;
	///<summary>If bOverrideResolution is true, this property will override the resolution of the render.</summary>
	public FIntPoint CustomResolution;
	///<summary>If this is true, this job will be rendered during a batch rendering, otherwise it will be skipped.</summary>
	public bool bIsEnabled;
	///<summary>The &#39;ID&#39; of this job, this &#39;ID&#39; is set by users. During rendering it will place all the output files of this job into a folder called after this &#39;ID&#39;, this means that this string can only contain file-safe characters.</summary>
	public string JobId;
	///<summary>The name of this job, this can be anything, it&#39;s set by the user, it serves as a way for the user to understand what job this is.</summary>
	public string JobName;
	///<summary>This is the folder in which the output files (of rendering) are placed into. To be more specific, the output files are placed in: {OutputDirectory}/{JobId}/, this folder will be created if it doesn&#39;t exist at the time of rendering.</summary>
	public string OutputDirectory;
	///<summary>The movie pipeline render preset. Render grid jobs are rendered using the movie pipeline plugin. This &#39;preset&#39; contains the configuration of that plugin.</summary>
	public UMoviePipelinePrimaryConfig RenderPreset;
	///<summary>The remote control plugin can be used to customize and modify the way a job is rendered. If remote control is being used, the property values of this job will be stored in this map (remote control entity id -&gt; value as bytes).</summary>
	public TMap<FGuid,FRenderGridRemoteControlPropertyData> RemoteControlValues;
}
