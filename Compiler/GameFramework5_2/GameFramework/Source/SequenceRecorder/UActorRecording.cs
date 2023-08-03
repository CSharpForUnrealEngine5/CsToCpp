#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorRecording.h")]
public partial class UActorRecording : USequenceRecordingBase {
	public static UClass StaticClass() {return default;}
	///<summary>ActorSettings</summary>
	public FActorRecordingSettings ActorSettings;
	///<summary>Whether this actor is active and to be recorded when the &#39;Record&#39; button is pressed.</summary>
	public bool bActive;
	///<summary>Whether to create a level sequence for this actor recording</summary>
	public bool bCreateLevelSequence;
	///<summary>The level sequence to record into</summary>
	public ULevelSequence TargetLevelSequence;
	///<summary>Optional target name to record to. If not specified, the actor label will be used</summary>
	public string TargetName;
	///<summary>Specify the take number for the new recording</summary>
	public uint TakeNumber;
	///<summary>Whether we should specify the target animation or auto-create it</summary>
	public bool bSpecifyTargetAnimation;
	///<summary>The target animation we want to record to</summary>
	public UAnimSequence TargetAnimation;
	///<summary>The settings to apply to this actor&#39;s animation</summary>
	public FAnimationRecordingSettings AnimationSettings;
	///<summary>Whether to record to &#39;possessable&#39; (i.e. level-owned) or &#39;spawnable&#39; (i.e. sequence-owned) actors. Defaults to the global setting.</summary>
	public bool bRecordToPossessable;
	///<summary>The actor we want to record</summary>
	public TSoftObjectPtr<AActor> ActorToRecord;
}
