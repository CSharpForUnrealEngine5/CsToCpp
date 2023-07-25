#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundMix.h")]
public partial class USoundMix : UObject {
// SoundMix
	public bool bApplyEQ;
	public float EQPriority;
	public FAudioEQEffect EQSettings;
	public TArray<FSoundClassAdjuster> SoundClassEffects;
	public float InitialDelay;
	public float FadeInTime;
	public float Duration;
	public float FadeOutTime;
	public bool bChanged;
}
