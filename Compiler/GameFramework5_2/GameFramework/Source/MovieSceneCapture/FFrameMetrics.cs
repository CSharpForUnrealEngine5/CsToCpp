#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Metrics that correspond to a particular frame</summary>
[CppInclude("MovieSceneCaptureProtocolBase.h")]
public partial struct FFrameMetrics {
	public float TotalElapsedTime;
	public float FrameDelta;
	public int FrameNumber;
	public int NumDroppedFrames;
}
