#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class represents a render grid, which is basically just a collection of render grid jobs.</summary>
[CppInclude("RenderGrid/RenderGrid.h")]
public partial class URenderGrid : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Event for when this asset is opened in the editor. The asset will also be closed and reopened during a blueprint compile.</summary>
	public  void ReceiveBeginEditor() {}
	///<summary>Event for when this asset is closed in the editor. The asset will also be closed and reopened during a blueprint compile.</summary>
	public  void ReceiveEndEditor() {}
	///<summary>The tick event, will only execute when the asset is open in the editor.</summary>
	public  void ReceiveTick(float DeltaTime) {}
	///<summary>Event for when batch rendering begins.</summary>
	public  void ReceiveBeginBatchRender(URenderGridQueue Queue) {}
	///<summary>Event for when batch rendering ends.</summary>
	public  void ReceiveEndBatchRender(URenderGridQueue Queue) {}
	///<summary>Event for when job rendering begins.</summary>
	public  void ReceiveBeginJobRender(URenderGridQueue Queue,URenderGridJob Job) {}
	///<summary>Event for when job rendering ends.</summary>
	public  void ReceiveEndJobRender(URenderGridQueue Queue,URenderGridJob Job) {}
	///<summary>Event for when job rendering for the viewport viewer-mode begins.</summary>
	public  void ReceiveBeginViewportRender(URenderGridJob Job) {}
	///<summary>Event for when job rendering for the viewport viewer-mode ends.</summary>
	public  void ReceiveEndViewportRender(URenderGridJob Job) {}
	///<summary>Renders all the enabled jobs of this render grid.</summary>
	public  URenderGridQueue Render() { return default; }
	///<summary>Renders all the given jobs of this render grid.</summary>
	public  URenderGridQueue RenderJobs(TArray<URenderGridJob> Jobs) { return default; }
	///<summary>Renders the given job of this render grid.</summary>
	public  URenderGridQueue RenderJob(URenderGridJob Job) { return default; }
	///<summary>Returns the GUID, which is randomly generated at creation.</summary>
	public  FGuid GetGuid() { return default; }
	///<summary>Randomly generates a new GUID.</summary>
	public  void GenerateNewGuid() {}
	///<summary>SetPropsSource</summary>
	public  void SetPropsSource(ERenderGridPropsSourceType InPropsSourceType,UObject InPropsSourceOrigin/*=nullptr*/) {}
	///<summary>GetPropsSource</summary>
	public  URenderGridPropsSourceBase GetPropsSource() { return default; }
	///<summary>GetPropsSourceType</summary>
	public  ERenderGridPropsSourceType GetPropsSourceType() { return default; }
	///<summary>GetPropsSourceOrigin</summary>
	public  UObject GetPropsSourceOrigin() { return default; }
	///<summary>GetDefaultLevelSequence</summary>
	public  ULevelSequence GetDefaultLevelSequence() { return default; }
	///<summary>SetDefaultLevelSequence</summary>
	public  void SetDefaultLevelSequence(ULevelSequence NewSequence) {}
	///<summary>GetDefaultRenderPreset</summary>
	public  UMoviePipelinePrimaryConfig GetDefaultRenderPreset() { return default; }
	///<summary>GetDefaultRenderPresetOutputSettings</summary>
	public  UMoviePipelineOutputSetting GetDefaultRenderPresetOutputSettings() { return default; }
	///<summary>SetDefaultRenderPreset</summary>
	public  void SetDefaultRenderPreset(UMoviePipelinePrimaryConfig NewRenderPreset) {}
	///<summary>GetDefaultOutputDirectory</summary>
	public  string GetDefaultOutputDirectory() { return default; }
	///<summary>GetDefaultOutputDirectoryForDisplay</summary>
	public  string GetDefaultOutputDirectoryForDisplay() { return default; }
	///<summary>SetDefaultOutputDirectory</summary>
	public  void SetDefaultOutputDirectory(string NewOutputDirectory) {}
	///<summary>ClearRenderGridJobs</summary>
	public  void ClearRenderGridJobs() {}
	///<summary>SetRenderGridJobs</summary>
	public  void SetRenderGridJobs(TArray<URenderGridJob> Jobs) {}
	///<summary>AddRenderGridJob</summary>
	public  void AddRenderGridJob(URenderGridJob Job) {}
	///<summary>RemoveRenderGridJob</summary>
	public  void RemoveRenderGridJob(URenderGridJob Job) {}
	///<summary>InsertRenderGridJob</summary>
	public  void InsertRenderGridJob(URenderGridJob Job,int Index) {}
	///<summary>HasAnyRenderGridJobs</summary>
	public  bool HasAnyRenderGridJobs() { return default; }
	///<summary>HasRenderGridJob</summary>
	public  bool HasRenderGridJob(URenderGridJob Job) { return default; }
	///<summary>GetIndexOfRenderGridJob</summary>
	public  int GetIndexOfRenderGridJob(URenderGridJob Job) { return default; }
	///<summary>GetRenderGridJobs</summary>
	public  TArray<URenderGridJob> GetRenderGridJobs() { return default; }
	///<summary>GetEnabledRenderGridJobs</summary>
	public  TArray<URenderGridJob> GetEnabledRenderGridJobs() { return default; }
	///<summary>GetDisabledRenderGridJobs</summary>
	public  TArray<URenderGridJob> GetDisabledRenderGridJobs() { return default; }
	///<summary>InsertRenderGridJobBefore</summary>
	public  void InsertRenderGridJobBefore(URenderGridJob Job,URenderGridJob BeforeJob) {}
	///<summary>InsertRenderGridJobAfter</summary>
	public  void InsertRenderGridJobAfter(URenderGridJob Job,URenderGridJob AfterJob) {}
	///<summary>Generates a unique job ID by grabbing the current time, as well as 16 random bytes, and converting that to a base64 string. *</summary>
	public  string GenerateUniqueRandomJobId() { return default; }
	///<summary>Generates a unique job ID by finding the currently highest job ID and increasing it by one. *</summary>
	public  string GenerateNextJobId() { return default; }
	///<summary>Finds whether given job ID already exists in this grid. *</summary>
	public  bool DoesJobIdExist(string JobId) { return default; }
	///<summary>Creates a new job. This job won&#39;t be added to the grid, so it will eventually be garbage collected. *</summary>
	public  URenderGridJob CreateTempRenderGridJob() { return default; }
	///<summary>Creates a new job and adds it to this grid. *</summary>
	public  URenderGridJob CreateAndAddNewRenderGridJob() { return default; }
	///<summary>Copy the given job in this grid. *</summary>
	public  URenderGridJob DuplicateAndAddRenderGridJob(URenderGridJob Job) { return default; }
	///<summary>Relocates the given job in this grid to the position of the given dropped-on job. *</summary>
	public  bool ReorderRenderGridJob(URenderGridJob Job,URenderGridJob DroppedOnJob,bool bAfter/*=true*/) { return default; }
	///<summary>The unique ID of this render grid.</summary>
	public FGuid Guid;
	///<summary>The settings of this render grid.</summary>
	public URenderGridSettings Settings;
	///<summary>The default values for new jobs.</summary>
	public URenderGridDefaults Defaults;
	///<summary>The jobs of this render grid.</summary>
	public TArray<URenderGridJob> RenderGridJobs;
	///<summary>True when it&#39;s currently executing a blueprint event, false otherwise.</summary>
	public bool bExecutingBlueprintEvent;
}
