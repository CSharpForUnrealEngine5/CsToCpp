#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorRecording.h")]
public partial class UActorRecording : USequenceRecordingBase {
// ActorRecording
	public FActorRecordingSettings ActorSettings;
	public bool bActive;
	public bool bCreateLevelSequence;
	public ULevelSequence TargetLevelSequence;
	public string TargetName;
	public uint TakeNumber;
	public bool bSpecifyTargetAnimation;
	public UAnimSequence TargetAnimation;
	public FAnimationRecordingSettings AnimationSettings;
	public bool bRecordToPossessable;
	public TSoftObjectPtr<AActor> ActorToRecord;
}
