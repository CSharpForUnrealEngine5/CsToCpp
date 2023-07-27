#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueue.h")]
///<summary>A queue is a list of jobs that have been executed, are executing and are waiting to be executed. These can be saved</summary>
public partial class UMoviePipelineQueue : UObject {
// MoviePipelineQueue
	public  UMoviePipelineExecutorJob AllocateNewJob(UClass InJobType) { return default; }
	public  void DeleteJob(UMoviePipelineExecutorJob InJob) {}
	public  void DeleteAllJobs() {}
	public  UMoviePipelineExecutorJob DuplicateJob(UMoviePipelineExecutorJob InJob) { return default; }
	public  TArray<UMoviePipelineExecutorJob> GetJobs() { return default; }
	public  UMoviePipelineQueue GetQueueOrigin() { return default; }
	public  void SetQueueOrigin(UMoviePipelineQueue InConfig) {}
	public  void CopyFrom(UMoviePipelineQueue InQueue) {}
	public  void SetJobIndex(UMoviePipelineExecutorJob InJob,int Index) {}
	public  bool IsDirty() { return default; }
	public  void SetIsDirty(bool bNewDirtyState) {}
	public TArray<UMoviePipelineExecutorJob> Jobs;
	public TSoftObjectPtr<UMoviePipelineQueue> QueueOrigin;
}
