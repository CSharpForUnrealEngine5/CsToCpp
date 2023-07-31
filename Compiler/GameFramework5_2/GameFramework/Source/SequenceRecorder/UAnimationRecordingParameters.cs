#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationRecorderParameters.h")]
public partial class UAnimationRecordingParameters : UObject {
	///<summary>Sample frame-rate of the recorded animation</summary>
	public FFrameRate SampleFrameRate;
	///<summary>If enabled, this animation recording will automatically end after a set amount of time</summary>
	public bool bEndAfterDuration;
	///<summary>The maximum duration of this animation recording</summary>
	public float MaximumDurationSeconds;
	///<summary>SampleRate</summary>
	public float SampleRate;
}
