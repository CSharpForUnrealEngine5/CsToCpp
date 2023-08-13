namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Streaming settings.</summary>
[CppInclude("Engine/CoreSettings.h")]
public partial class UStreamingSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Enables separate thread for package streaming. Requires restart to take effect.</summary>
	public bool AsyncLoadingThreadEnabled;
	///<summary>Enables log warning if time limit for time-sliced package streaming has been exceeded.</summary>
	public bool WarnIfTimeLimitExceeded;
	///<summary>Multiplier for time limit exceeded warning time threshold.</summary>
	public float TimeLimitExceededMultiplier;
	///<summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
	public float TimeLimitExceededMinTime;
	///<summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
	public int MinBulkDataSizeForAsyncLoading;
	///<summary>Whether to allow background level streaming.</summary>
	public bool UseBackgroundLevelStreaming;
	///<summary>Whether to use the entire time limit even if blocked on I/O.</summary>
	public bool AsyncLoadingUseFullTimeLimit;
	///<summary>Maximum amount of time to spend doing asynchronous loading (ms per frame).</summary>
	public float AsyncLoadingTimeLimit;
	///<summary>Additional time to spend asynchronous loading during a high priority load.</summary>
	public float PriorityAsyncLoadingExtraTime;
	///<summary>Maximum allowed time to spend for actor registration steps during level streaming (ms per frame).</summary>
	public float LevelStreamingActorsUpdateTimeLimit;
	///<summary>Additional time to spend on actor registration steps during a high priority load.</summary>
	public float PriorityLevelStreamingActorsUpdateExtraTime;
	///<summary>Batching granularity used to register actor components during level streaming.</summary>
	public int LevelStreamingComponentsRegistrationGranularity;
	///<summary>Batching granularity used to add primitives to scene in parallel when registering actor components during level streaming.</summary>
	public int LevelStreamingAddPrimitiveGranularity;
	///<summary>Maximum allowed time to spend while unregistering components during level streaming (ms per frame).</summary>
	public float LevelStreamingUnregisterComponentsTimeLimit;
	///<summary>Batching granularity used to unregister actor components during level streaming.</summary>
	public int LevelStreamingComponentsUnregistrationGranularity;
	///<summary>If enabled, streaming will be flushed when exiting application, otherwise it will be cancelled.</summary>
	public bool FlushStreamingOnExit;
	///<summary>Enables the event driven loader in cooked builds (default). Disabling EDL will result in using deprecated loading path.</summary>
	public bool EventDrivenLoaderEnabled;
}
