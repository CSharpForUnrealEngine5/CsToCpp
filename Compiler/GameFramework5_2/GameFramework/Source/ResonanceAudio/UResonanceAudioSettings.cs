#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResonanceAudioSettings.h")]
public partial class UResonanceAudioSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to submix where reverb plugin audio is routed.</summary>
	public FSoftObjectPath OutputSubmix;
	///<summary>Global Quality mode to use for directional sound sources.</summary>
	public ERaQualityMode QualityMode;
	///<summary>Default settings for global reverb: This is overridden when a player enters Audio Volumes.</summary>
	public FSoftObjectPath GlobalReverbPreset;
	///<summary>Default settings for global source settings</summary>
	public FSoftObjectPath GlobalSourcePreset;
}
