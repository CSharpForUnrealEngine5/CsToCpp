#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGrid.h")]
///<summary>This class represents a render grid, which is basically just a collection of render grid jobs.</summary>
public partial class URenderGrid : UObject {
// RenderGrid
	public void ReceiveBeginEditor() {}
	public void ReceiveEndEditor() {}
	public void ReceiveTick(float DeltaTime) {}
	public void ReceiveBeginBatchRender(UObject Queue) {}
	public void ReceiveEndBatchRender(UObject Queue) {}
	public void ReceiveBeginJobRender(UObject Queue,UObject Job) {}
	public void ReceiveEndJobRender(UObject Queue,UObject Job) {}
	public void ReceiveBeginViewportRender(UObject Job) {}
	public void ReceiveEndViewportRender(UObject Job) {}
	public UObject Render() { return default; }
	public UObject RenderJobs(TArray<UObject> Jobs) { return default; }
	public UObject RenderJob(UObject Job) { return default; }
	public FGuid GetGuid() { return default; }
	public void GenerateNewGuid() {}
	public void SetPropsSource(ERenderGridPropsSourceType InPropsSourceType,UObject InPropsSourceOrigin/*=nullptr*/) {}
	public UObject GetPropsSource() { return default; }
	public ERenderGridPropsSourceType GetPropsSourceType() { return default; }
	public UObject GetPropsSourceOrigin() { return default; }
	public UObject GetDefaultLevelSequence() { return default; }
	public void SetDefaultLevelSequence(UObject NewSequence) {}
	public UObject GetDefaultRenderPreset() { return default; }
	public UObject GetDefaultRenderPresetOutputSettings() { return default; }
	public void SetDefaultRenderPreset(UObject NewRenderPreset) {}
	public string GetDefaultOutputDirectory() { return default; }
	public string GetDefaultOutputDirectoryForDisplay() { return default; }
	public void SetDefaultOutputDirectory(string NewOutputDirectory) {}
	public void ClearRenderGridJobs() {}
	public void SetRenderGridJobs(TArray<UObject> Jobs) {}
	public void AddRenderGridJob(UObject Job) {}
	public void RemoveRenderGridJob(UObject Job) {}
	public void InsertRenderGridJob(UObject Job,int Index) {}
	public bool HasAnyRenderGridJobs() { return default; }
	public bool HasRenderGridJob(UObject Job) { return default; }
	public int GetIndexOfRenderGridJob(UObject Job) { return default; }
	public TArray<UObject> GetRenderGridJobs() { return default; }
	public TArray<UObject> GetEnabledRenderGridJobs() { return default; }
	public TArray<UObject> GetDisabledRenderGridJobs() { return default; }
	public void InsertRenderGridJobBefore(UObject Job,UObject BeforeJob) {}
	public void InsertRenderGridJobAfter(UObject Job,UObject AfterJob) {}
	public string GenerateUniqueRandomJobId() { return default; }
	public string GenerateNextJobId() { return default; }
	public bool DoesJobIdExist(string JobId) { return default; }
	public UObject CreateTempRenderGridJob() { return default; }
	public UObject CreateAndAddNewRenderGridJob() { return default; }
	public UObject DuplicateAndAddRenderGridJob(UObject Job) { return default; }
	public bool ReorderRenderGridJob(UObject Job,UObject DroppedOnJob,bool bAfter/*=true*/) { return default; }
	public FGuid Guid;
	public URenderGridSettings Settings;
	public URenderGridDefaults Defaults;
	public TArray<URenderGridJob> RenderGridJobs;
	public bool bExecutingBlueprintEvent;
}
