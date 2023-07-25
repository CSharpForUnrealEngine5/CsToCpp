#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceMediaController.h")]
///<summary>Replicated actor class that is responsible for instigating various cinematic assets (Media, Audio, Level Sequences) in a synchronized fasion</summary>
public partial class ALevelSequenceMediaController : AActor {
// LevelSequenceMediaController
	public void Play() {}
	public UObject GetMediaComponent() { return default; }
	public UObject GetSequence() { return default; }
	public void SynchronizeToServer(float DesyncThresholdSeconds/*=2.0f*/) {}
	public void OnRep_ServerStartTimeSeconds() {}
	public ALevelSequenceActor Sequence;
	public UMediaComponent MediaComponent;
	public float ServerStartTimeSeconds;
}
