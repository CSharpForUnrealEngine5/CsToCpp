#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGridQueue.h")]
///<summary>This class is responsible for rendering the given render grid jobs.</summary>
public partial class URenderGridQueue : UObject {
// RenderGridQueue
	public static void CloseEditorOnCompletion() {}
	public  void AddJob(URenderGridJob Job) {}
	public  void Pause() {}
	public  void Resume() {}
	public  void Cancel() {}
	public  bool IsStarted() { return default; }
	public  bool IsPaused() { return default; }
	public  bool IsCanceled() { return default; }
	public  bool IsFinished() { return default; }
	public  bool IsCurrentlyRendering() { return default; }
	public  URenderGrid GetRenderGrid() { return default; }
	public  string GetJobStatus(URenderGridJob Job) { return default; }
	public  TArray<URenderGridJob> GetJobs() { return default; }
	public  int GetJobsCount() { return default; }
	public  int GetJobsCompletedCount() { return default; }
	public  float GetStatusPercentage() { return default; }
	public  int GetJobsRemainingCount() { return default; }
	public  string GetStatus() { return default; }
	public TArray<URenderGridJob> RemainingJobs;
	public TMap<URenderGridJob,URenderGridMoviePipelineRenderJob> Entries;
	public URenderGrid RenderGrid;
	public bool bStarted;
	public bool bPaused;
	public bool bCanceled;
	public bool bFinished;
	public FRenderGridManagerPreviousPropValues PreviousProps;
	public FRenderGridPreviousEngineFpsSettings PreviousFrameLimitSettings;
}
