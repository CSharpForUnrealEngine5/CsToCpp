#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CoreSettings.h")]
///<summary>Streaming settings.</summary>
public partial class UStreamingSettings : UDeveloperSettings {
// StreamingSettings
	public bool AsyncLoadingThreadEnabled;
	public bool WarnIfTimeLimitExceeded;
	public float TimeLimitExceededMultiplier;
	public float TimeLimitExceededMinTime;
	public int MinBulkDataSizeForAsyncLoading;
	public bool UseBackgroundLevelStreaming;
	public bool AsyncLoadingUseFullTimeLimit;
	public float AsyncLoadingTimeLimit;
	public float PriorityAsyncLoadingExtraTime;
	public float LevelStreamingActorsUpdateTimeLimit;
	public float PriorityLevelStreamingActorsUpdateExtraTime;
	public int LevelStreamingComponentsRegistrationGranularity;
	public int LevelStreamingAddPrimitiveGranularity;
	public float LevelStreamingUnregisterComponentsTimeLimit;
	public int LevelStreamingComponentsUnregistrationGranularity;
	public bool FlushStreamingOnExit;
	public bool EventDrivenLoaderEnabled;
}
