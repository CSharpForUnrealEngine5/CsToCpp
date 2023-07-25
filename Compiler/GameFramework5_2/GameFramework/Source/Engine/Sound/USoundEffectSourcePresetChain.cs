#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundEffectSource.h")]
///<summary>Chain of source effect presets that can be shared between referencing sounds.</summary>
public partial class USoundEffectSourcePresetChain : UObject {
// SoundEffectSourcePresetChain
	public TArray<FSourceEffectChainEntry> Chain;
	public bool bPlayEffectChainTails;
}
