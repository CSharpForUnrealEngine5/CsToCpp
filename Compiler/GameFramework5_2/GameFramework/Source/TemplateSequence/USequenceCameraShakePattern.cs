#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceCameraShake.h")]
///<summary>A camera shake pattern that plays a sequencer animation.</summary>
public partial class USequenceCameraShakePattern : UCameraShakePattern {
// SequenceCameraShakePattern
	public UCameraAnimationSequence Sequence;
	public float PlayRate;
	public float Scale;
	public float BlendInTime;
	public float BlendOutTime;
	public float RandomSegmentDuration;
	public bool bRandomSegment;
	public UCameraAnimationSequencePlayer Player;
	public UCameraAnimationSequenceCameraStandIn CameraStandIn;
}
