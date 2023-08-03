#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replicated actor class that is responsible for instigating various cinematic assets (Media, Audio, Level Sequences) in a synchronized fasion</summary>
[CppInclude("SequenceMediaController.h")]
public partial class ALevelSequenceMediaController : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Play</summary>
	public  void Play() {}
	///<summary>Access this actor&#39;s media component</summary>
	public  UMediaComponent GetMediaComponent() { return default; }
	///<summary>Access this actor&#39;s Level Sequence Actor</summary>
	public  ALevelSequenceActor GetSequence() { return default; }
	///<summary>Forcibly synchronize the sequence to the server&#39;s position if it has diverged by more than the specified threshold</summary>
	public  void SynchronizeToServer(float DesyncThresholdSeconds/*=2.0f*/) {}
	///<summary>OnRep_ServerStartTimeSeconds</summary>
	public  void OnRep_ServerStartTimeSeconds() {}
	///<summary>Pointer to the sequence actor to use for playback</summary>
	public ALevelSequenceActor Sequence;
	///<summary>Media component that contains the media player to synchronize with</summary>
	public UMediaComponent MediaComponent;
	///<summary>Replicated time at which the server started the sequence (taken from AGameStateBase::GetServerWorldTimeSeconds)</summary>
	public float ServerStartTimeSeconds;
}
