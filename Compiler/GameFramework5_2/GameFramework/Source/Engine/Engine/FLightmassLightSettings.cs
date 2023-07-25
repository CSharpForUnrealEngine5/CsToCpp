#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Per-light settings for Lightmass</summary>
public partial struct FLightmassLightSettings {
// LightmassLightSettings
	public float IndirectLightingSaturation;
	public float ShadowExponent;
	public bool bUseAreaShadowsForStationaryLight;
}
