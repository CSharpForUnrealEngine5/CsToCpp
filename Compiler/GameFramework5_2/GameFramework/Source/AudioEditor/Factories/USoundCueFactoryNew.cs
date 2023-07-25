#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/SoundCueFactoryNew.h")]
public partial class USoundCueFactoryNew : UFactory {
// SoundCueFactoryNew
	public USoundWave InitialSoundWave;
	public TArray<TWeakObjectPtr<USoundWave>> InitialSoundWaves;
	public UDialogueWave InitialDialogueWave;
	public TArray<TWeakObjectPtr<UDialogueWave>> InitialDialogueWaves;
}
