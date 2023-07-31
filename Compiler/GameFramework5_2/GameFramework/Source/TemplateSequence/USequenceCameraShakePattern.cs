#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A camera shake pattern that plays a sequencer animation.</summary>
[CppInclude("SequenceCameraShake.h")]
public partial class USequenceCameraShakePattern : UCameraShakePattern {
	///<summary>Source camera animation sequence to play.</summary>
	public UCameraAnimationSequence Sequence;
	///<summary>Scalar defining how fast to play the anim.</summary>
	public float PlayRate;
	///<summary>Scalar defining how &quot;intense&quot; to play the anim.</summary>
	public float Scale;
	///<summary>Linear blend-in time.</summary>
	public float BlendInTime;
	///<summary>Linear blend-out time.</summary>
	public float BlendOutTime;
	///<summary>When bRandomSegment is true, defines how long the sequence should play.</summary>
	public float RandomSegmentDuration;
	///<summary>When true, plays a random snippet of the sequence for RandomSegmentDuration seconds.</summary>
	public bool bRandomSegment;
	///<summary>The player we use to play the camera animation sequence</summary>
	public UCameraAnimationSequencePlayer Player;
	///<summary>Standin for the camera actor and components</summary>
	public UCameraAnimationSequenceCameraStandIn CameraStandIn;
}
