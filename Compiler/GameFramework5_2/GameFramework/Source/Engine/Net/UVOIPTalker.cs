#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/VoiceConfig.h")]
public partial class UVOIPTalker : UActorComponent {
// VOIPTalker
	public static UVOIPTalker CreateTalkerForPlayer(APlayerState OwningState) { return default; }
	public  void RegisterWithPlayerState(APlayerState OwningState) {}
	public  float GetVoiceLevel() { return default; }
	public  void BPOnTalkingBegin(UAudioComponent AudioComponent) {}
	public  void BPOnTalkingEnd() {}
	public FVoiceSettings Settings;
}
