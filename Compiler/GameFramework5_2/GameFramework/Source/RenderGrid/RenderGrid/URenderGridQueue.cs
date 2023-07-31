#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is responsible for rendering the given render grid jobs.</summary>
[CppInclude("RenderGrid/RenderGridQueue.h")]
public partial class URenderGridQueue : UObject {
	///<summary>Call this function to make it so that the editor will be closed when all rendering queues finish execution. This function has to be only called once.</summary>
	public static void CloseEditorOnCompletion() {}
	///<summary>Queues the given job.</summary>
	public  void AddJob(URenderGridJob Job) {}
	///<summary>Pauses the queue.</summary>
	public  void Pause() {}
	///<summary>Resumes the queue.</summary>
	public  void Resume() {}
	///<summary>Cancels the current and the remaining queued jobs. Relies on the internal movie pipeline implementation of job canceling on whether this will stop the current render grid job from rendering or not. Will always prevent new render grid jobs from rendering.</summary>
	public  void Cancel() {}
	///<summary>Returns true if this queue has been started.</summary>
	public  bool IsStarted() { return default; }
	///<summary>Returns true if this queue is currently paused.</summary>
	public  bool IsPaused() { return default; }
	///<summary>Returns true if this queue has been canceled.</summary>
	public  bool IsCanceled() { return default; }
	///<summary>Returns true if this queue has been canceled.</summary>
	public  bool IsFinished() { return default; }
	///<summary>Returns true if this queue is the one that&#39;s currently rendering, returns false if it hasn&#39;t started yet, or if it&#39;s waiting in the queue, or if it has finished.</summary>
	public  bool IsCurrentlyRendering() { return default; }
	///<summary>Retrieves the rendering status of the given render grid job.</summary>
	public  URenderGrid GetRenderGrid() { return default; }
	///<summary>Retrieves the rendering status of the given render grid job.</summary>
	public  string GetJobStatus(URenderGridJob Job) { return default; }
	///<summary>Returns all the jobs that have been and will be rendered.</summary>
	public  TArray<URenderGridJob> GetJobs() { return default; }
	///<summary>Returns the number of jobs that have been and will be rendered.</summary>
	public  int GetJobsCount() { return default; }
	///<summary>Returns the number of jobs that have finished rendering. Basically just returns [Get Jobs Count] minus [Get Jobs Remaining Count].</summary>
	public  int GetJobsCompletedCount() { return default; }
	///<summary>Returns the percentage of jobs finished, this includes the progression of the job that is currently rendering.</summary>
	public  float GetStatusPercentage() { return default; }
	///<summary>Returns the number of jobs that are still left to render, includes the job that is currently rendering.</summary>
	public  int GetJobsRemainingCount() { return default; }
	///<summary>Returns the status of the rendering process.</summary>
	public  string GetStatus() { return default; }
	///<summary>The render grid jobs that are to be rendered, removed when one is grabbed from it and added to the execution queue.</summary>
	public TArray<URenderGridJob> RemainingJobs;
	///<summary>The render grid jobs that are to be rendered, mapped to the movie pipeline render job of each specific render grid job.</summary>
	public TMap<URenderGridJob,URenderGridMoviePipelineRenderJob> Entries;
	///<summary>The render grid of the given render grid job that will be rendered.</summary>
	public URenderGrid RenderGrid;
	///<summary>Whether the queue has been started yet.</summary>
	public bool bStarted;
	///<summary>Whether the queue has been paused.</summary>
	public bool bPaused;
	///<summary>Whether the queue has been canceled.</summary>
	public bool bCanceled;
	///<summary>Whether the queue has been finished.</summary>
	public bool bFinished;
	///<summary>The property values that have been overwritten by the currently applied render grid job property values.</summary>
	public FRenderGridManagerPreviousPropValues PreviousProps;
	///<summary>The engine framerate settings values that have been overwritten by the currently applied engine framerate settings values.</summary>
	public FRenderGridPreviousEngineFpsSettings PreviousFrameLimitSettings;
}
