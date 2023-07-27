#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGrid.h")]
///<summary>This class represents a render grid, which is basically just a collection of render grid jobs.</summary>
public partial class URenderGrid : UObject {
// RenderGrid
	public  void ReceiveBeginEditor() {}
	public  void ReceiveEndEditor() {}
	public  void ReceiveTick(float DeltaTime) {}
	public  void ReceiveBeginBatchRender(URenderGridQueue Queue) {}
	public  void ReceiveEndBatchRender(URenderGridQueue Queue) {}
	public  void ReceiveBeginJobRender(URenderGridQueue Queue,URenderGridJob Job) {}
	public  void ReceiveEndJobRender(URenderGridQueue Queue,URenderGridJob Job) {}
	public  void ReceiveBeginViewportRender(URenderGridJob Job) {}
	public  void ReceiveEndViewportRender(URenderGridJob Job) {}
	public  URenderGridQueue Render() { return default; }
	public  URenderGridQueue RenderJobs(TArray<URenderGridJob> Jobs) { return default; }
	public  URenderGridQueue RenderJob(URenderGridJob Job) { return default; }
	public  FGuid GetGuid() { return default; }
	public  void GenerateNewGuid() {}
	public  void SetPropsSource(ERenderGridPropsSourceType InPropsSourceType,UObject InPropsSourceOrigin/*=nullptr*/) {}
	public  URenderGridPropsSourceBase GetPropsSource() { return default; }
	public  ERenderGridPropsSourceType GetPropsSourceType() { return default; }
	public  UObject GetPropsSourceOrigin() { return default; }
	public  ULevelSequence GetDefaultLevelSequence() { return default; }
	public  void SetDefaultLevelSequence(ULevelSequence NewSequence) {}
	public  UMoviePipelinePrimaryConfig GetDefaultRenderPreset() { return default; }
	public  UMoviePipelineOutputSetting GetDefaultRenderPresetOutputSettings() { return default; }
	public  void SetDefaultRenderPreset(UMoviePipelinePrimaryConfig NewRenderPreset) {}
	public  string GetDefaultOutputDirectory() { return default; }
	public  string GetDefaultOutputDirectoryForDisplay() { return default; }
	public  void SetDefaultOutputDirectory(string NewOutputDirectory) {}
	public  void ClearRenderGridJobs() {}
	public  void SetRenderGridJobs(TArray<URenderGridJob> Jobs) {}
	public  void AddRenderGridJob(URenderGridJob Job) {}
	public  void RemoveRenderGridJob(URenderGridJob Job) {}
	public  void InsertRenderGridJob(URenderGridJob Job,int Index) {}
	public  bool HasAnyRenderGridJobs() { return default; }
	public  bool HasRenderGridJob(URenderGridJob Job) { return default; }
	public  int GetIndexOfRenderGridJob(URenderGridJob Job) { return default; }
	public  TArray<URenderGridJob> GetRenderGridJobs() { return default; }
	public  TArray<URenderGridJob> GetEnabledRenderGridJobs() { return default; }
	public  TArray<URenderGridJob> GetDisabledRenderGridJobs() { return default; }
	public  void InsertRenderGridJobBefore(URenderGridJob Job,URenderGridJob BeforeJob) {}
	public  void InsertRenderGridJobAfter(URenderGridJob Job,URenderGridJob AfterJob) {}
	public  string GenerateUniqueRandomJobId() { return default; }
	public  string GenerateNextJobId() { return default; }
	public  bool DoesJobIdExist(string JobId) { return default; }
	public  URenderGridJob CreateTempRenderGridJob() { return default; }
	public  URenderGridJob CreateAndAddNewRenderGridJob() { return default; }
	public  URenderGridJob DuplicateAndAddRenderGridJob(URenderGridJob Job) { return default; }
	public  bool ReorderRenderGridJob(URenderGridJob Job,URenderGridJob DroppedOnJob,bool bAfter/*=true*/) { return default; }
	public FGuid Guid;
	public URenderGridSettings Settings;
	public URenderGridDefaults Defaults;
	public TArray<URenderGridJob> RenderGridJobs;
	public bool bExecutingBlueprintEvent;
}
