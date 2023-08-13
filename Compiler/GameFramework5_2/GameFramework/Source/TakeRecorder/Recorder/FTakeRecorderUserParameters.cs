namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderParameters.h")]
public partial struct FTakeRecorderUserParameters {
	public bool bMaximizeViewport;
	public float CountdownSeconds;
	public float EngineTimeDilation;
	public bool bResetPlayhead;
	public bool bStopAtPlaybackEnd;
	public bool bRemoveRedundantTracks;
	public float ReduceKeysTolerance;
	public bool bSaveRecordedAssets;
	public bool bAutoLock;
	public bool bAutoSerialize;
}
