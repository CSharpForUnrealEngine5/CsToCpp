#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Per-object settings for Lightmass</summary>
public partial struct FLightmassPrimitiveSettings {
// LightmassPrimitiveSettings
	public bool bUseTwoSidedLighting;
	public bool bShadowIndirectOnly;
	public bool bUseEmissiveForStaticLighting;
	public bool bUseVertexNormalForHemisphereGather;
	public float EmissiveLightFalloffExponent;
	public float EmissiveLightExplicitInfluenceRadius;
	public float EmissiveBoost;
	public float DiffuseBoost;
	public float FullyOccludedSamplesFraction;
}
