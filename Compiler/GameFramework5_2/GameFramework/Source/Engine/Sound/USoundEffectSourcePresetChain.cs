#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Chain of source effect presets that can be shared between referencing sounds.</summary>
[CppInclude("Sound/SoundEffectSource.h")]
public partial class USoundEffectSourcePresetChain : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Chain of source effects to use for this sound source.</summary>
	public TArray<FSourceEffectChainEntry> Chain;
	///<summary>Whether to keep the source alive for the duration of the effect chain tails.</summary>
	public bool bPlayEffectChainTails;
}
