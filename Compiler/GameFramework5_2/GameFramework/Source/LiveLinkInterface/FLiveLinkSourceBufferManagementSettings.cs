#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkSourceSettings.h")]
public partial struct FLiveLinkSourceBufferManagementSettings {
	public bool bValidEngineTimeEnabled;
	public float ValidEngineTime;
	public float EngineTimeOffset;
	public double EngineTimeClockOffset;
	public double SmoothEngineTimeOffset;
	public FFrameRate TimecodeFrameRate_DEPRECATED;
	public bool bGenerateSubFrame;
	public FFrameRate DetectedFrameRate;
	public bool bUseTimecodeSmoothLatest;
	public FFrameRate SourceTimecodeFrameRate;
	public bool bValidTimecodeFrameEnabled;
	public int ValidTimecodeFrame;
	public float TimecodeFrameOffset;
	public double TimecodeClockOffset;
	public int LatestOffset;
	public int MaxNumberOfFrameToBuffered;
	public bool bKeepAtLeastOneFrame;
}
