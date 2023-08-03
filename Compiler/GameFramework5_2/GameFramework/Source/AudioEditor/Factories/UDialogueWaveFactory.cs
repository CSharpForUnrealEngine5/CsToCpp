#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/DialogueWaveFactory.h")]
public partial class UDialogueWaveFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>An initial sound wave to place in the newly created dialogue wave</summary>
	public USoundWave InitialSoundWave;
	///<summary>An initial speaking dialogue voice to place in the newly created dialogue wave</summary>
	public UDialogueVoice InitialSpeakerVoice;
	///<summary>Whether an initial target dialogue voice should be set</summary>
	public bool HasSetInitialTargetVoice;
	///<summary>An initial target dialogue voices to place in the newly created dialogue wave</summary>
	public TArray<UDialogueVoice> InitialTargetVoices;
}
