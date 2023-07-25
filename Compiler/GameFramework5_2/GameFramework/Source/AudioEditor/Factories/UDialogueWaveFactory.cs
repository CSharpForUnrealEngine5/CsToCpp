#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/DialogueWaveFactory.h")]
public partial class UDialogueWaveFactory : UFactory {
// DialogueWaveFactory
	public USoundWave InitialSoundWave;
	public UDialogueVoice InitialSpeakerVoice;
	public bool HasSetInitialTargetVoice;
	public TArray<UDialogueVoice> InitialTargetVoices;
}
