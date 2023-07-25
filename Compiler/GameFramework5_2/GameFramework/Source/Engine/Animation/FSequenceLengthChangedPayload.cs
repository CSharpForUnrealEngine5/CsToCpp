#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/AnimDataNotifications.h")]
public partial struct FSequenceLengthChangedPayload {
// SequenceLengthChangedPayload
	public float PreviousLength;
	public float T0;
	public float T1;
	public FFrameNumber PreviousNumberOfFrames;
	public FFrameNumber Frame0;
	public FFrameNumber Frame1;
}
