#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/VoiceConfig.h")]
public partial class UVOIPTalker : UActorComponent {
// VOIPTalker
	public UObject CreateTalkerForPlayer(UObject OwningState) { return default; }
	public void RegisterWithPlayerState(UObject OwningState) {}
	public float GetVoiceLevel() { return default; }
	public void BPOnTalkingBegin(UObject AudioComponent) {}
	public void BPOnTalkingEnd() {}
	public FVoiceSettings Settings;
}
