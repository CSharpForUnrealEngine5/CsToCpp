namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-object settings for Lightmass</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FLightmassPrimitiveSettings {
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
