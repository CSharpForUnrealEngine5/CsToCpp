#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A queue is a list of jobs that have been executed, are executing and are waiting to be executed. These can be saved</summary>
[CppInclude("MoviePipelineQueue.h")]
public partial class UMoviePipelineQueue : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Allocates a new Job in this Queue. The Queue owns the jobs for memory management purposes,</summary>
	public  UMoviePipelineExecutorJob AllocateNewJob(UClass InJobType) { return default; }
	///<summary>Deletes the specified job from the Queue.</summary>
	public  void DeleteJob(UMoviePipelineExecutorJob InJob) {}
	///<summary>Delete all jobs from the Queue.</summary>
	public  void DeleteAllJobs() {}
	///<summary>Duplicate the specific job and return the duplicate. Configurations are duplicated and not shared.</summary>
	public  UMoviePipelineExecutorJob DuplicateJob(UMoviePipelineExecutorJob InJob) { return default; }
	///<summary>Get all of the Jobs contained in this Queue.</summary>
	public  TArray<UMoviePipelineExecutorJob> GetJobs() { return default; }
	///<summary>Gets the queue that this queue was originally based on (if any). The origin will only be set on transient</summary>
	public  UMoviePipelineQueue GetQueueOrigin() { return default; }
	///<summary>Sets the queue that this queue originated from (if any). The origin should only be set for transient queues.</summary>
	public  void SetQueueOrigin(UMoviePipelineQueue InConfig) {}
	///<summary>Replace the contents of this queue with a copy of the contents from another queue.</summary>
	public  void CopyFrom(UMoviePipelineQueue InQueue) {}
	///<summary>Set the index of the given job</summary>
	public  void SetJobIndex(UMoviePipelineExecutorJob InJob,int Index) {}
	///<summary>Gets the dirty state of this queue. Note that dirty state is only tracked when the editor is active.</summary>
	public  bool IsDirty() { return default; }
	///<summary>Sets the dirty state of this queue. Generally the queue will correctly track the dirty state; however, there are</summary>
	public  void SetIsDirty(bool bNewDirtyState) {}
	///<summary>Jobs</summary>
	public TArray<UMoviePipelineExecutorJob> Jobs;
	///<summary>The queue that this queue originated from. Helpful for determining the source of the queue when this queue is transient.</summary>
	public TSoftObjectPtr<UMoviePipelineQueue> QueueOrigin;
}
