namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-light settings for Lightmass</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FLightmassLightSettings {
	public float IndirectLightingSaturation;
	public float ShadowExponent;
	public bool bUseAreaShadowsForStationaryLight;
}
