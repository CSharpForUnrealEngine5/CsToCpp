namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneGameplayCueSections.h")]
public partial struct FMovieSceneGameplayCueKey {
	public FGameplayCueTag Cue;
	public FVector Location;
	public FVector Normal;
	public FName AttachSocketName;
	public float NormalizedMagnitude;
	public FMovieSceneObjectBindingID Instigator;
	public FMovieSceneObjectBindingID EffectCauser;
	public UPhysicalMaterial PhysicalMaterial;
	public int GameplayEffectLevel;
	public int AbilityLevel;
	public bool bAttachToBinding;
}
