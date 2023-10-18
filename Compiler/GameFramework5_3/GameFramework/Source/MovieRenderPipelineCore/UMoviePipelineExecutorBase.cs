namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Movie Pipeline Executor is responsible for executing an array of Movie Pipelines,</summary>
[CppInclude("MoviePipelineExecutor.h")]
public partial class UMoviePipelineExecutorBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Execute the provided Queue. You are responsible for deciding how to handle each job</summary>
	public void Execute(UMoviePipelineQueue InPipelineQueue) {}
	///<summary>Report the current state of the executor. This is used to know if we can call Execute again.</summary>
	public bool IsRendering() { return default; }
	///<summary>Called once at the beginning of each engine frame.</summary>
	public void OnBeginFrame() {}
	///<summary>Set the status of this Executor. Does nothing in default implementations, but a useful shorthand</summary>
	public void SetStatusMessage(string InStatus) {}
	///<summary>Get the current status message for this job. May be an empty string.</summary>
	public string GetStatusMessage() { return default; }
	///<summary>Set the progress of this Executor. Does nothing in default implementations, but a useful shorthand</summary>
	public void SetStatusProgress(float InProgress) {}
	///<summary>Get the current progress as last set by SetStatusProgress. 0 by default.</summary>
	public float GetStatusProgress() { return default; }
	///<summary>Abort the currently executing job.</summary>
	public void CancelCurrentJob() {}
	///<summary>Abort the currently executing job and skip all other jobs.</summary>
	public void CancelAllJobs() {}
	///<summary>Specify which MoviePipeline class type should be created by this executor when processing jobs.</summary>
	public void SetMoviePipelineClass(UClass InPipelineClass) {}
	///<summary>This should be called when the Executor has finished executing all of the things</summary>
	public virtual void OnExecutorFinishedImpl() {}
	///<summary>OnExecutorErroredImpl</summary>
	public virtual void OnExecutorErroredImpl(UMoviePipeline ErroredPipeline,bool bFatal,FText ErrorReason) {}
	///<summary>Called when the Executor has finished all jobs. Reports success if no jobs</summary>
	public FOnMoviePipelineExecutorFinished OnExecutorFinishedDelegate;
	///<summary>Called when an individual job reports a warning/error. Jobs are considered fatal</summary>
	public FOnMoviePipelineExecutorErrored OnExecutorErroredDelegate;
	///<summary>Attempts to connect a socket to the specified host and port. This is a blocking call.</summary>
	public bool ConnectSocket(string InHostName,int InPort) { return default; }
	///<summary>* Disconnects the socket (if currently connected.)</summary>
	public void DisconnectSocket() {}
	///<summary>Sends a socket message if the socket is currently connected. Messages back will happen in the OnSocketMessageRecieved event.</summary>
	public bool SendSocketMessage(string InMessage) { return default; }
	///<summary>Returns true if the socket is currently connected, false otherwise. Call ConnectSocket to attempt a connection.</summary>
	public bool IsSocketConnected() { return default; }
	///<summary>If this executor has been configured to connect to a socket, this event will be called each time the socket recieves something.</summary>
	public FMoviePipelineSocketMessageRecieved SocketMessageRecievedDelegate;
	///<summary>Sends a asynchronous HTTP request. Responses will be returned in the the OnHTTPResponseRecieved event.</summary>
	public int SendHTTPRequest(string InURL,string InVerb,string InMessage,TMap<string,string> InHeaders) { return default; }
	///<summary>If an HTTP Request has been made and a response returned, the returned response will be broadcast on this event.</summary>
	public FMoviePipelineHttpResponseRecieved HTTPResponseRecievedDelegate;
	///<summary>DebugWidgetClass</summary>
	public UClass DebugWidgetClass;
	///<summary>Arbitrary data that can be associated with the executor. Not used by default implementations, nor read.</summary>
	public string UserData;
	///<summary>Which Pipeline Class should be created by this Executor. May be null.</summary>
	public UClass TargetPipelineClass;
}
