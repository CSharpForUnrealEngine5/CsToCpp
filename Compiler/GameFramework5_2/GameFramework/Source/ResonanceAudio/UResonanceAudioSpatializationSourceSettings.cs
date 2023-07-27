#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResonanceAudioSpatializationSourceSettings.h")]
public partial class UResonanceAudioSpatializationSourceSettings : USpatializationPluginSourceSettingsBase {
// ResonanceAudioSpatializationSourceSettings
	public ERaSpatializationMethod SpatializationMethod;
	public float Pattern;
	public float Sharpness;
	public bool bToggleVisualization;
	public float Scale;
	public float Spread;
	public ERaDistanceRolloffModel Rolloff;
	public float MinDistance;
	public float MaxDistance;
	public  void SetSoundSourceDirectivity(float InPattern,float InSharpness) {}
	public  void SetSoundSourceSpread(float InSpread) {}
}
