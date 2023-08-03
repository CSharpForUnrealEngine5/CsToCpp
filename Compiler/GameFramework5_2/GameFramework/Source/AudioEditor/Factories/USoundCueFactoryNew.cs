#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/SoundCueFactoryNew.h")]
public partial class USoundCueFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Initial sound wave to place in the newly created cue</summary>
	public USoundWave InitialSoundWave;
	///<summary>Initial sound wave(s) to place in the newly created cue(s)</summary>
	public TArray<TWeakObjectPtr<USoundWave>> InitialSoundWaves;
	///<summary>An initial dialogue wave to place in the newly created cue</summary>
	public UDialogueWave InitialDialogueWave;
	///<summary>Initial dialogue wave(s) to place in the newly created cue(s)</summary>
	public TArray<TWeakObjectPtr<UDialogueWave>> InitialDialogueWaves;
}
