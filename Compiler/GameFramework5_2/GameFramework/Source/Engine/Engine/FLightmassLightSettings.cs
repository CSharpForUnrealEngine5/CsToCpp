#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-light settings for Lightmass</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FLightmassLightSettings {
	public float IndirectLightingSaturation;
	public float ShadowExponent;
	public bool bUseAreaShadowsForStationaryLight;
}
