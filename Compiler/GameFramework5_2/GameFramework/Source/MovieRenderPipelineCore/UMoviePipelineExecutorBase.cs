#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineExecutor.h")]
///<summary>A Movie Pipeline Executor is responsible for executing an array of Movie Pipelines,</summary>
public partial class UMoviePipelineExecutorBase : UObject {
// MoviePipelineExecutorBase
	public void Execute(UObject InPipelineQueue) {}
	public bool IsRendering() { return default; }
	public void OnBeginFrame() {}
	public void SetStatusMessage(string InStatus) {}
	public string GetStatusMessage() { return default; }
	public void SetStatusProgress(float InProgress) {}
	public float GetStatusProgress() { return default; }
	public void CancelCurrentJob() {}
	public void CancelAllJobs() {}
	public void SetMoviePipelineClass(UClass InPipelineClass) {}
	public void OnExecutorFinishedImpl() {}
	public void OnExecutorErroredImpl(UObject ErroredPipeline,bool bFatal,string ErrorReason) {}
	public FOnMoviePipelineExecutorFinished OnExecutorFinishedDelegate;
	public FOnMoviePipelineExecutorErrored OnExecutorErroredDelegate;
	public bool ConnectSocket(string InHostName,int InPort) { return default; }
	public void DisconnectSocket() {}
	public bool SendSocketMessage(string InMessage) { return default; }
	public bool IsSocketConnected() { return default; }
	public FMoviePipelineSocketMessageRecieved SocketMessageRecievedDelegate;
	public int SendHTTPRequest(string InURL,string InVerb,string InMessage,TMap<string,string> InHeaders) { return default; }
	public FMoviePipelineHttpResponseRecieved HTTPResponseRecievedDelegate;
	public UClass DebugWidgetClass;
	public string UserData;
	public UClass TargetPipelineClass;
}
