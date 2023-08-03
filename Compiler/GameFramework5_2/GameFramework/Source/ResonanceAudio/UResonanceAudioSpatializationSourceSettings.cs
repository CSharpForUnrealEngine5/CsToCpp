#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResonanceAudioSpatializationSourceSettings.h")]
public partial class UResonanceAudioSpatializationSourceSettings : USpatializationPluginSourceSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Spatialization method to use for sound object(s). NOTE: Has no effect if &#39;Stereo Panning&#39; global quality mode is selected for the project</summary>
	public ERaSpatializationMethod SpatializationMethod;
	///<summary>Directivity pattern: 0.0 (omnidirectional), 0.5 (cardioid), 1.0 (figure-of-8)</summary>
	public float Pattern;
	///<summary>Sharpness of the directivity pattern. Higher values result in a narrower sound emission beam</summary>
	public float Sharpness;
	///<summary>Whether to visualize directivity pattern in the viewport.</summary>
	public bool bToggleVisualization;
	///<summary>Scale (for directivity pattern visualization only).</summary>
	public float Scale;
	///<summary>Spread (width) of the sound source (in degrees). Note: spread control is not available if &#39;Stereo Panning&#39; global quality mode is enabled for the project and / or &#39;Stereo Panning&#39; spatialization mode is enabled for the sound source</summary>
	public float Spread;
	///<summary>Roll-off model to use for sound source distance attenuation. Select &#39;None&#39; (default) to use Unreal attenuation settings</summary>
	public ERaDistanceRolloffModel Rolloff;
	///<summary>Minimum distance to apply the chosen attenuation method (default = 100.0 cm)</summary>
	public float MinDistance;
	///<summary>Maximum distance to apply the chosen attenuation method ((default = 50000.0 cm)</summary>
	public float MaxDistance;
	///<summary>Sets the sound source directivity, applies, and updates</summary>
	public  void SetSoundSourceDirectivity(float InPattern,float InSharpness) {}
	///<summary>Sets the sound source spread (width), applies, and updates</summary>
	public  void SetSoundSourceSpread(float InSpread) {}
}
