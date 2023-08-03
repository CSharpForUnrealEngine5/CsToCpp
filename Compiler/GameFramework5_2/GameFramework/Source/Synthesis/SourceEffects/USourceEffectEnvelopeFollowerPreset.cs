#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectEnvelopeFollower.h")]
public partial class USourceEffectEnvelopeFollowerPreset : USoundEffectSourcePreset {
	public static UClass StaticClass() {return default;}
	///<summary>SetSettings</summary>
	public  void SetSettings(FSourceEffectEnvelopeFollowerSettings InSettings) {}
	///<summary>Registers an envelope follower listener with the effect.</summary>
	public  void RegisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener) {}
	///<summary>Unregisters an envelope follower listener with the effect.</summary>
	public  void UnregisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener) {}
	///<summary>Settings</summary>
	public FSourceEffectEnvelopeFollowerSettings Settings;
}
