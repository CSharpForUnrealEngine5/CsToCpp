namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is responsible for rendering the given render grid jobs.</summary>
[CppInclude("RenderGrid/RenderGridQueue.h")]
public partial class URenderGridQueue : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Call this function to make it so that the editor will be closed when all rendering queues have finished. This function has to only be called once.</summary>
	public static void CloseEditorOnCompletion() {}
	///<summary>Returns the currently rendering queue, or NULL if there isn&#39;t any currently rendering.</summary>
	public static URenderGridQueue GetCurrentlyRenderingQueue() { return default; }
	///<summary>Returns the number of rendering queues that are currently queued up. This also includes the currently rendering queue.</summary>
	public static int GetRemainingRenderingQueuesCount() { return default; }
	///<summary>Obtains a string representation of this object. Shouldn&#39;t be used for anything other than logging/debugging.</summary>
	public string ToDebugString() { return default; }
	///<summary>Returns the GUID, which is randomly generated at creation.</summary>
	public FGuid GetGuid() { return default; }
	///<summary>Randomly generates a new GUID.</summary>
	public void GenerateNewGuid() {}
	///<summary>Queues the given job.</summary>
	public void AddJob(URenderGridJob Job) {}
	///<summary>Pauses the queue.</summary>
	public void Pause() {}
	///<summary>Resumes the queue.</summary>
	public void Resume() {}
	///<summary>Cancels the current and the remaining queued jobs. Relies on the internal movie pipeline implementation of job canceling on whether this will stop the current render grid job from rendering or not. Will always prevent new render grid jobs from rendering.</summary>
	public void Cancel() {}
	///<summary>Returns true if this queue has been started.</summary>
	public bool IsStarted() { return default; }
	///<summary>Returns true if this queue is currently paused.</summary>
	public bool IsPaused() { return default; }
	///<summary>Returns true if this queue has been canceled.</summary>
	public bool IsCanceled() { return default; }
	///<summary>Returns true if this queue has been canceled.</summary>
	public bool IsFinished() { return default; }
	///<summary>Returns true if this queue is the one that&#39;s currently rendering, returns false if it hasn&#39;t started yet, or if it&#39;s waiting in the queue, or if it has finished.</summary>
	public bool IsCurrentlyRendering() { return default; }
	///<summary>Retrieves the rendering status of the given render grid job.</summary>
	public URenderGrid GetRenderGrid() { return default; }
	///<summary>Retrieves the currently rendering render grid job, can return NULL.</summary>
	public URenderGridJob GetCurrentlyRenderingJob() { return default; }
	///<summary>Retrieves the rendering status of the given render grid job. Will return an empty string if this job wasn&#39;t found in this queue.</summary>
	public string GetJobStatus(URenderGridJob Job) { return default; }
	///<summary>Returns the percentage of the rendering status of the given render grid job. Will return 0 if this job wasn&#39;t found in this queue.</summary>
	public float GetJobStatusPercentage(URenderGridJob Job) { return default; }
	///<summary>Returns all the jobs that have been and will be rendered.</summary>
	public TArray<URenderGridJob> GetJobs() { return default; }
	///<summary>Returns the number of jobs that have been and will be rendered.</summary>
	public int GetJobsCount() { return default; }
	///<summary>Returns the number of jobs that are still left to render, includes the job that is currently rendering.</summary>
	public int GetJobsRemainingCount() { return default; }
	///<summary>Returns the number of jobs that have finished rendering. Basically just returns [Get Jobs Count] minus [Get Jobs Remaining Count].</summary>
	public int GetJobsCompletedCount() { return default; }
	///<summary>Returns the status of the rendering process.</summary>
	public string GetStatus() { return default; }
	///<summary>Returns the percentage of jobs finished, this includes the progression of the job that is currently rendering.</summary>
	public float GetStatusPercentage() { return default; }
	///<summary>The unique ID of this queue.</summary>
	public FGuid Guid;
	///<summary>The render grid jobs that are to be rendered, removed when one is grabbed from it and added to the execution queue.</summary>
	public TArray<URenderGridJob> RemainingJobs;
	///<summary>The render grid jobs that are to be rendered, mapped to the movie pipeline render job of each specific render grid job.</summary>
	public TMap<URenderGridJob,URenderGridMoviePipelineRenderJob> Entries;
	///<summary>The render grid jobs that is currently being rendered.</summary>
	public URenderGridJob CurrentJob;
	///<summary>The movie pipeline render job that is currently being rendered.</summary>
	public URenderGridMoviePipelineRenderJob CurrentEntry;
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
