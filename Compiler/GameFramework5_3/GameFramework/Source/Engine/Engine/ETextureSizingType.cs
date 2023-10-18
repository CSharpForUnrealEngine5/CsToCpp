namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MaterialMerging.h")]
public enum ETextureSizingType {
	TextureSizingType_UseSingleTextureSize=0,
	TextureSizingType_UseAutomaticBiasedSizes=1,
	TextureSizingType_UseManualOverrideTextureSize=2,
	TextureSizingType_UseSimplygonAutomaticSizing=3,
	TextureSizingType_AutomaticFromTexelDensity=4,
	TextureSizingType_AutomaticFromMeshScreenSize=5,
	TextureSizingType_AutomaticFromMeshDrawDistance=6,
	TextureSizingType_MAX=7,
}
